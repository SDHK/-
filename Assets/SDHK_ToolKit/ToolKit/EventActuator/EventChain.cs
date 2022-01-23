using System.Collections;
using System.Collections.Generic;
using ObjectPool_;
using UnityEngine;


namespace EventActuator
{
    /// <summary>
    /// 事件链
    /// </summary>
    public class EventChain : IObjectPoolItem
    {
        private static ObjectPool<EventChain> pool = new ObjectPool<EventChain>()
        { clock = 600 }
        .RegisterManager();

        //私有构造函数禁止new
        private EventChain() { }
        /// <summary>
        /// 获取
        /// </summary>
        public static EventChain Get() => pool.Get();
        /// <summary>
        /// 回收
        /// </summary>
        public void Recycle() => pool.Recycle(this);

        /// <summary>
        /// 执行指针
        /// </summary>
        public int eventPointer = 0;

        /// <summary>
        /// 是否结束
        /// </summary>
        public bool isDone => eventPointer >= events.Count;

        /// <summary>
        /// 事件队列
        /// </summary>
        public List<EventNode> events = new List<EventNode>();//当前进程任务队列


        public void ObjectOnNew() { }
        public void ObjectOnClear() { }
        public void ObjectOnGet() { eventPointer = 0; }
        public void ObjectOnRecycle()
        {
            foreach (var task in events)
            {
                task.Recycle();
            }
            events.Clear();
        }


        /// <summary>
        /// 添加一个任务节点
        /// </summary>
        /// <param name="taskNode">任务节点</param>
        /// <returns>当前任务进程</returns>
        public EventChain Add(EventNode taskNode)
        {
            events.Add(taskNode);
            return this;
        }

        public void Update()
        {
            if (eventPointer < events.Count)
            {
                if (events[eventPointer].isDone)
                {
                    eventPointer++;
                }
                else
                {
                    events[eventPointer].Update();
                }
            }
        }
    }

}