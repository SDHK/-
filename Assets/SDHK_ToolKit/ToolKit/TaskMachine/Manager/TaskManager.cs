


/***********************************

 * 作者: 闪电黑客

 * 日期: 2021/02/20  23:44:44

 * 最后日期: 2021/02/21  14:48:56

 * 描述: 
    任务执行管理器
    主要功能为：生成 和 驱动 任务执行器 运行
    全部执行器都由update驱动。

    执行器分为匿名执行器和绑定执行器两种。

    匿名执行器： 通过TaskManager调用直接运行。
                运行完毕后，结束释放执行器。

        多次调用：每次调用都会开启一个新的执行器。


    绑定执行器： 通过绑定Object后调用运行。
                执行器运行完毕 或者 object为null时 结束释放执行器。
       
        多次调用：当前执行器 未执行完时，会将任务追加到当前执行器。
                当前执行器 执行完毕时，开启一个新的执行器 执行任务。

***********************************/



using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;
using Singleton;

namespace TaskMachine
{

    /// <summary>
    /// 任务执行管理器
    /// </summary>
    public class TaskManager : SingletonMonoBase<TaskManager>
    {

        private List<TaskActuator> bindTasks = new List<TaskActuator>();

        private List<TaskActuator> tasks = new List<TaskActuator>();

        //===【全局对象池】===
        private Dictionary<Type, IObjectPool> objFactory = new Dictionary<Type, IObjectPool>();
        //===============




        /// <summary>
        /// 任务管理器内部对象池
        /// </summary>
        public static ObjectPool<T> GetPool<T>()
        where T : IDisposable, new()
        {

            Type type_ = typeof(T);

            if (!Instance().objFactory.ContainsKey(type_))
            {
                instance.objFactory.Add(type_, new ObjectPool<T>(() => new T())
                .ClearObject((t) => t.Dispose())
                );
            }
            return (ObjectPool<T>)instance.objFactory[type_];

        }


        /// <summary>
        /// 任务管理器内部对象池：清除对象
        /// </summary>
        public static void Clear<T>(int Count = 0)
        where T : IDisposable, new()
        {
            ObjectPool<T> objectPool = GetPool<T>();

            objectPool.Clear(Count);

            if (Count == 0) Instance().objFactory.Remove(typeof(T));

            System.GC.Collect();

        }

        /// <summary>
        /// 任务管理器内部对象池：清空全部对象池
        /// </summary>
        public static void Clear()
        {
            foreach (var objPool in Instance().objFactory)
            {
                ((IDisposable)objPool.Value).Dispose();
            }
            instance.objFactory.Clear();
            System.GC.Collect();

        }



        /// <summary>
        /// 新建启动一个匿名任务：执行完后结束，无法中途结束。
        /// </summary>
        /// <param name="model">运行模式</param>
        /// <returns>任务进程</returns>
        public static TaskProcess TaskRun(TaskModel model = TaskModel.Update)
        {
            TaskActuator TA = TaskActuator.Get();

            TaskProcess taskProcess = TaskProcess.Get(TA, model);

            TA.RunMainTask(taskProcess);

            Instance().tasks.Add(TA);

            return TA.MainProcess;
        }



        /// <summary>
        ///  启动一个绑定任务：未执行完时，新任务以追加的形式执行
        /// </summary>
        /// <param name="obj">绑定对象</param>
        /// <param name="model">运行模式</param>
        /// <returns>绑定的任务进程</returns>
        public static TaskProcess TaskRun(object obj, TaskModel model = TaskModel.Update)
        {
            if (!Instance().bindTasks.Any((TA) => TA.obj == obj))
            {
                TaskActuator TA = TaskActuator.Get(obj);

                TaskProcess taskProcess = TaskProcess.Get(TA, model);

                TA.RunMainTask(taskProcess);

                instance.bindTasks.Add(TA);

                return TA.MainProcess;
            }
            else
            {
                return instance.bindTasks.Find((TA) => TA.obj == obj).MainProcess;
            }
        }

        /// <summary>
        /// 查询对象是否有绑定任务
        /// </summary>
        /// <param name="obj">绑定对象</param>
        /// <returns>true\false</returns>
        public static bool Contains(object obj)
        {
            return Instance().bindTasks.Any((TA) => TA.obj == obj);
        }



        /// <summary>
        /// 强制结束一个绑定任务
        /// </summary>
        /// <param name="obj">绑定对象</param>
        public static void TaskKill(object obj)
        {
            Instance().bindTasks.Find((TA) => TA.obj == obj).MainProcess.Release();
        }


        /// <summary>
        /// 移除一个绑定任务
        /// </summary>
        public static void RemoveBindTask(TaskActuator taskActuator)
        {
            Instance().bindTasks.Remove(taskActuator);
        }


        /// <summary>
        /// 移除一个任务进程
        /// </summary>
        /// <param name="taskActuator">任务进程</param>
        public static void RemoveTask(TaskActuator taskActuator)
        {
            Instance().tasks.Remove(taskActuator);
        }



        //===【Unity生命周期：update】======================================


        private void Update()
        {

            if (Input.GetKeyDown(KeyCode.Q))
            {
                string log = "";

                foreach (var item in objFactory)
                {
                    log += "\n" + item.Key.Name + " : " + item.Value.Count();
                }

                Debug.Log("【运行中】 匿名:" + tasks.Count + " | 绑定:" + bindTasks.Count + " | 【回收】:" + log);
            }

            for (int i = 0; i < tasks.Count; i++)
            {
                tasks[i].Update();
            }

            for (int i = 0; i < bindTasks.Count; i++)
            {
                bindTasks[i].Update();
            }

        }

        private void LateUpdate()
        {

            for (int i = 0; i < tasks.Count; i++)
            {
                tasks[i].LateUpdate();
            }

            for (int i = 0; i < bindTasks.Count; i++)
            {
                bindTasks[i].LateUpdate();
            }
        }

        private void FixedUpdate()
        {

            for (int i = 0; i < tasks.Count; i++)
            {
                tasks[i].FixedUpdate();
            }


            for (int i = 0; i < bindTasks.Count; i++)
            {
                if (bindTasks[i].obj != null)//对象不为空时
                {
                    if (!bindTasks[i].obj.Equals(null))//判断内容是否为空
                    {
                        bindTasks[i].FixedUpdate();
                    }
                    else
                    {
                        bindTasks[i].MainProcess.Release();
                    }
                }
                else
                {
                    bindTasks[i].MainProcess.Release();
                }
            }
        }


        //===【Unity生命周期】======================================

        private void OnEnable()
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                tasks[i].ThreadRun = true;
            }

            for (int i = 0; i < bindTasks.Count; i++)
            {
                bindTasks[i].ThreadRun = true;
            }
        }
        private void OnDisable()
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                tasks[i].ThreadRun = false;
            }

            for (int i = 0; i < bindTasks.Count; i++)
            {
                bindTasks[i].ThreadRun = false;
            }
        }

        private void OnDestroy()
        {
            bindTasks.Clear();
            tasks.Clear();
            Clear();
        }




    }

}