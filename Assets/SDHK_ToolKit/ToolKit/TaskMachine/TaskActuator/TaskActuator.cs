


/******************************

 * 作者: 闪电黑客

 * 日期: 2021/02/22 10:08:09

 * 最后日期: 2021/02/22 13:26:25

 * 描述: 
    任务执行器：主要管理 TaskProcess 主进程、协程、子进程 的 [执行\挂起]

    MainProcess为主进程，当主进程判断结束，会通知管理器移除自己结束运行。
    
    其余List<TaskProcess>为工作进程池，运行不同模式 进程 的Update
 
    任务执行器只能开启一个线程update，
    所以多线程模式的，都运行在同一个线程里


    【迭代器模式】


******************************/



using System;
using System.Collections.Generic;
using System.Threading;

namespace TaskMachine
{

    /// <summary>
    /// 运行模式
    /// </summary>
    public enum TaskModel
    {

        /// <summary>
        /// 运行在Update
        /// </summary>
        Update,

        /// <summary>
        /// 运行在LateUpdate
        /// </summary>
        LateUpdate,

        /// <summary>
        /// 运行在FixedUpdate
        /// </summary>
        FixedUpdate,

        /// <summary>
        /// 运行在Thread
        /// </summary>
        Thread
    }

    /// <summary>
    /// 任务执行器
    /// </summary>
    public class TaskActuator : IDisposable
    {

        private static ObjectPool<TaskActuator> objectPool = TaskManager.GetPool<TaskActuator>();

        /// <summary>
        /// 绑定对象：用于管理器索引
        /// </summary>
        internal object obj;

        //用于线程挂起停止
        internal bool ThreadRun = true;

        /// <summary>
        /// 是否绑定模式：在初始化时自动判断
        /// </summary>
        private bool isBind;

        // 用于线程结束
        private bool ThreadDone = false;

        // 主进程
        private TaskProcess mainProcess;


        /// <summary>
        /// 主进程
        /// </summary>
        public TaskProcess MainProcess
        {
            get { return mainProcess; }
        }


        private List<TaskProcess> taskUpdate = new List<TaskProcess>();
        private List<TaskProcess> taskLateUpdate = new List<TaskProcess>();
        private List<TaskProcess> taskFixedUpdate = new List<TaskProcess>();


        private List<TaskProcess> taskThread = new List<TaskProcess>();

        private bool disposedValue;

        private Thread thread;


        // Profiler.BeginSample("AAA");
        // Profiler.EndSample();


        /// <summary>
        /// 获取执行器
        /// </summary>
        public static TaskActuator Get(object obj = null)
        {
            var TA = objectPool.Get();

            TA.isBind = obj != null;
            TA.obj = obj;
            TA.ThreadRun = true;
            TA.ThreadDone = false;

            return TA;
        }

        /// <summary>
        /// 启动运行主线程
        /// </summary>
        /// <param name="mainProcess">任务线程</param>
        public void RunMainTask(TaskProcess mainProcess)
        {
            this.mainProcess = mainProcess;
            PlayTask(this.mainProcess);
        }

        /// <summary>
        /// 释放执行器
        /// </summary>
        private void Release()
        {
            obj = null;

            mainProcess = null;


            taskUpdate.Clear();
            taskLateUpdate.Clear();
            taskFixedUpdate.Clear();


            taskThread.Clear();

            ThreadRun = false;

            if (isBind)//将自己移除出管理器
            {
                TaskManager.RemoveBindTask(this);
            }
            else
            {
                TaskManager.RemoveTask(this);
            }

            objectPool.Set(this);//对象池回收自己
        }


        /// <summary>
        /// 启动运行一个任务进程
        /// </summary>
        /// <param name="taskProcess">进程</param>
        public void PlayTask(TaskProcess taskProcess)
        {
            var pool = EnumPool(taskProcess.Model);

            if (!pool.Contains(taskProcess))
            {
                EnumPool(taskProcess.Model).Add(taskProcess);
            }
        }

        /// <summary>
        /// 暂停挂起一个任务进程
        /// </summary>
        /// <param name="taskProcess">进程</param>
        /// <param name="env"></param>
        public void StopTask(TaskProcess taskProcess)
        {
            EnumPool(taskProcess.Model).Remove(taskProcess);
        }

        /// <summary>
        /// 结束一个任务进程
        /// </summary>
        /// <param name="taskProcess">进程</param>
        /// <param name="env"></param>
        public void DoneTask(TaskProcess taskProcess)
        {
            StopTask(taskProcess);

            if (mainProcess == taskProcess)//为主进程时会释放掉自己
            {
                Release();
            }
        }

        #region  update

        public void Update()
        {
            TaskUpdate(taskUpdate);
        }

        public void LateUpdate()
        {
            TaskUpdate(taskLateUpdate);
        }

        public void FixedUpdate()
        {
            TaskUpdate(taskFixedUpdate);
        }

        #endregion

        //多线程的Update
        private void ThreadUpdate()
        {
            while (!ThreadDone)
            {
                if (ThreadRun)
                {
                    TaskUpdate(taskThread);
                }
                Thread.Sleep(1);//!通过一次休眠使得线程可以被跳出，否则线程跳不出，cpu 被拉到100% 会卡死电脑
            }
        }

        //任务遍历执行
        private void TaskUpdate(List<TaskProcess> processes)
        {
            for (int i = 0; i < processes.Count; i++)
            {
                processes[i].Update();
            }
        }


        /// <summary>
        /// 枚举筛选进程池
        /// </summary>
        /// <param name="model">运行模式</param>
        /// <returns>运行池</returns>
        private List<TaskProcess> EnumPool(TaskModel model)
        {
            switch (model)
            {
                case TaskModel.Update: return taskUpdate;
                case TaskModel.LateUpdate: return taskLateUpdate;
                case TaskModel.FixedUpdate: return taskFixedUpdate;
                case TaskModel.Thread:

                    if (thread == null)
                    {
                        thread = new Thread(ThreadUpdate) { IsBackground = true };
                        thread.Start();
                    }
                    return taskThread;

                default: return null;
            }
        }

        /// <summary>
        /// 销毁
        /// </summary>
        public void Dispose()
        {
            if (thread != null)
            {
                thread.Abort();
                ThreadRun = false;
                ThreadDone = true;
                thread = null;
            }
        }
    }



}