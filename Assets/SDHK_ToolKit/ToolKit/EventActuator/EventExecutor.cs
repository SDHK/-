using System.Collections;
using System.Collections.Generic;
using System.Threading;
using ObjectPool_;
using UnityEngine;



namespace EventActuator
{

    /// <summary>
    /// 事件执行者
    /// </summary>
    public partial class EventExecutor : IObjectPoolItem
    {
        private static ObjectPool<EventExecutor> pool = new ObjectPool<EventExecutor>()
        { clock = 600 }
        .RegisterManager();

        //私有构造函数禁止new
        private EventExecutor() { }

        /// <summary>
        /// 获取
        /// </summary>
        public static EventExecutor Get() => pool.Get();

        /// <summary>
        /// 回收
        /// </summary>
        public void Recycle() => pool.Recycle(this);

        /// <summary>
        /// 任务链堆栈
        /// </summary>
        public List<EventChain> eventChains = new List<EventChain>();

        /// <summary>
        /// 是否结束
        /// </summary>
        public bool isDone = false;

        /// <summary>
        /// 是否运行
        /// </summary>
        public bool isRun = true;

        private Thread thread;//在多线程执行

        /// <summary>
        /// 运行在多线程
        /// </summary>
        public void RunThread()
        {
            if (thread == null)
            {
                thread = new Thread(ThreadUpdate) { IsBackground = true };
            }
            thread.Start();
        }

        //多线程的update
        private void ThreadUpdate()
        {
            while (!isDone)
            {
                Update();
                Thread.Sleep(1);
            }
        }


        public void Update()
        {
            if (isRun)
            {
                if (eventChains.Count > 0)
                {
                    isDone = false;
                    if (eventChains[eventChains.Count - 1].isDone)
                    {
                        eventChains[eventChains.Count - 1].Recycle();
                        eventChains.RemoveAt(eventChains.Count - 1);
                    }
                    else
                    {
                        eventChains[eventChains.Count - 1].Update();
                    }
                }
                else
                {
                    isDone = true;
                }
            }
        }


        public void ObjectOnNew() { }
        public void ObjectOnClear() { }
        public void ObjectOnGet() { isDone = false; }
        public void ObjectOnRecycle()
        {
            isRun = false;
            foreach (var eventList in eventChains)
            {
                eventList.Recycle();
            }
            eventChains.Clear();
            isDone = true;
            thread.Abort();
        }

    }
}