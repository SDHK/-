


/***********************************

 * 作者: 闪电黑客

 * 日期: 2021/02/20  23:44:44

 * 最后日期: 2021/02/21  14:49:45

 * 描述: 
    TaskProcess：维护一个委托队列，
    通过Update执行委托队列，直至队列清空。
    依托TaskActuator运行。

    树状结构延伸出子进程和协程，当协程和子进程全部执行完毕，当前进程才会判断结束。
    所有进程都依托taskActuator运行。


    主要功能：
        执行委托队列

    设计目的
        通过该组件完成一些 (在u3d中实现比较麻烦) 的功能

***********************************/


using System;
using System.Collections.Generic;
using TaskMachine.Node;
using UnityEngine;

namespace TaskMachine
{

    /// <summary>
    /// 任务进程
    /// </summary>
    public partial class TaskProcess : IDisposable
    {
        /// <summary>
        /// 全局对象池
        /// </summary>
        /// <typeparam name="TaskProcess"></typeparam>
        public static ObjectPool<TaskProcess> objectPool = TaskManager.GetPool<TaskProcess>();

        private bool isDone = false;//是否运行完毕
        private TaskModel model = TaskModel.Update;//运行环境

        /// <summary>
        /// 是否运行完毕：可能会被对象池回收利用，建议用OnComplete回调
        /// </summary>
        public bool IsDone { get { return isDone; } }

        /// <summary>
        /// 获取运行模式
        /// </summary>
        public TaskModel Model { get { return model; } }



        private Action onComplete;//完成回调

        private TaskActuator taskActuator;//任务执行器引用

        //===[拿到引用用于判断]===

        //! 测试发现：使用LinkedList进行频繁插入到末端，会产生GC 48 B ，List则不会，个人估计是LinkedListNode造成的
        private TaskProcess parentTask;//父进程
        private List<TaskProcess> inserts = new List<TaskProcess>();//插入的子线程

        private TaskProcess mainTask;//主进程
        private List<TaskProcess> coroutines = new List<TaskProcess>();//协程

        //======================
        private Queue<TaskNode> taskQueue = new Queue<TaskNode>();//当前进程任务队列




        /// <summary>
        /// 获取进程
        /// </summary>
        /// <param name="taskActuator">执行器</param>
        /// <param name="model">运行模式</param>
        public static TaskProcess Get(TaskActuator taskActuator, TaskModel model)
        {
            var TP = objectPool.Get();

            TP.isDone = false;
            TP.taskActuator = taskActuator;
            TP.model = model;

            return TP;
        }

        /// <summary>
        /// 进程执行完成时回调
        /// </summary>
        /// <param name="Complete">回调委托</param>
        /// <returns></returns>
        public TaskProcess OnComplete(Action Complete)
        {
            onComplete = Complete;
            return this;
        }

        /// <summary>
        /// 添加一个任务节点
        /// </summary>
        /// <param name="taskNode">任务节点</param>
        /// <returns>当前任务进程</returns>
        private TaskProcess Add(TaskNode taskNode)
        {
            taskQueue.Enqueue(taskNode);
            return this;
        }

        /// <summary>
        /// 插入子进程
        /// </summary>
        /// <returns>子进程</returns>
        public TaskProcess Insert()
        {
            TaskProcess taskProcess = TaskProcess.Get(this.taskActuator, this.Model);
            return Insert(taskProcess);
        }

        /// <summary>
        /// 插入子进程
        /// </summary>
        /// <param name="model">运行环境</param>
        /// <returns>子进程</returns>
        public TaskProcess Insert(TaskModel model)
        {
            TaskProcess taskProcess = TaskProcess.Get(this.taskActuator, model);
            return Insert(taskProcess);
        }



        /// <summary>
        /// 启动协同进程
        /// </summary>
        /// <returns>协同进程</returns>
        public TaskProcess Coroutine()
        {
            TaskProcess taskProcess = TaskProcess.Get(this.taskActuator, this.Model);
            return Coroutine(taskProcess);
        }

        /// <summary>
        /// 启动协同进程
        /// </summary>
        /// <param name="model">运行环境</param>
        /// <returns>协同任务</returns>
        public TaskProcess Coroutine(TaskModel model)
        {
            TaskProcess taskProcess = TaskProcess.Get(this.taskActuator, model);
            return Coroutine(taskProcess);
        }

        /// <summary>
        /// 插入子进程
        /// </summary>
        /// <param name="insert">子进程</param>
        /// <returns>子进程</returns>
        public TaskProcess Insert(TaskProcess insert)
        {
            if (insert != null)
            {
                insert.taskActuator.PlayTask(insert);//加入到运行器
                inserts.Add(insert);//GC产生根源
                insert.parentTask = this;
                if (inserts.Count == 1) taskActuator.StopTask(this);//把当前进程踢出执行器
            }
            return insert;
        }

        /// <summary>
        /// 启动协同进程
        /// </summary>
        /// <param name="coroutine">协同任务</param>
        /// <returns>协同任务</returns>
        public TaskProcess Coroutine(TaskProcess coroutine)
        {
            if (coroutine != null)
            {
                coroutine.taskActuator.PlayTask(coroutine);//加入到执行器
                coroutines.Add(coroutine);
                coroutine.mainTask = this;
            }
            return coroutine;
        }

        //移除一个子进程
        private void RemoveInsert(TaskProcess task)
        {
            inserts.Remove(task);
            if (inserts.Count == 0 && taskActuator != null) taskActuator.PlayTask(this);//把当前进程加入到执行器
        }

        //移除一个协同进程
        private void RemoveCoroutine(TaskProcess task)
        {
            coroutines.Remove(task);
        }

        /// <summary>
        /// 进程的Update
        /// </summary>
        public void Update()
        {
            if (taskQueue.Count != 0)
            {
                try
                {
                    taskQueue.Peek().Update();
                }
                catch (Exception e)
                {
                    Debug.LogError("TaskManager出错，倒数第" + taskQueue.Count + "个， 节点名:" + taskQueue.Peek().GetType().Name + "\n" + e);
                    ToNext();
                }

            }
            else if (coroutines.Count == 0)//没有进程的情况下，当前任务为空时结束进程
            {
                Done();
            }
        }

        /// <summary>
        /// 执行到下一个节点
        /// </summary>
        public void ToNext()
        {
            if (taskQueue.Count != 0)
            {
                taskQueue.Dequeue().Recycle();
            }
        }


        /// <summary>
        /// 完成当前进程
        /// </summary>
        private void Done()
        {
            isDone = true;

            if (onComplete != null) onComplete();//全部结束后回调通知进程已完成

            Release();//释放自己并把自己踢出执行器
        }


        /// <summary>
        /// 释放整个主进程
        /// </summary>
        public void ReleaseMian()
        {
            taskActuator.MainProcess.Release();
        }

        /// <summary>
        /// 释放进程：包括全部子进程和协程
        /// </summary>
        public void Release()
        {
            while (taskQueue.Count != 0)
            {
                taskQueue.Dequeue().Recycle();//回收释放自己的任务队列
            }

            foreach (var insert in inserts)
            {
                insert.Release();//先清除子进程
            }

            foreach (var coroutine in coroutines)
            {
                coroutine.Release();//先清除协程
            }

            if (parentTask != null)//假如自己是子进程
            {
                parentTask.RemoveInsert(this);//把自己从父进程踢出
            }

            if (mainTask != null)//假如自己是协程
            {
                mainTask.RemoveCoroutine(this);//把自己从主进程踢出.
            }

            if (taskActuator != null) taskActuator.DoneTask(this);//将自己踢出执行器

            isDone = false; //标记未完成
            onComplete = null;
            taskActuator = null;
            parentTask = null;
            mainTask = null;

            objectPool.Set(this);//对象池回收自己

        }


        /// <summary>
        /// 销毁
        /// </summary>
        public void Dispose()
        {

        }
    }

}