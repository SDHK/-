





/******************************

 * 作者: 闪电黑客

 * 日期: 2021/02/26 17:50:59

 * 最后日期: 2021/02/26 17:51:23

 * 描述: 
    任务节点，继承TaskNode加入TaskProcess的任务队列进行执行。

    主要功能：
        给进程添加 定时闹钟事件 功能

    设计目的：

        添加 时间轴 事件 功能。
        通过ClockReset刷新闹钟计时
        用ClockSet对闹钟定时
        当计时到指定时间后，就会调用定时的回调事件。


******************************/





using System;
using TaskMachine.Node;

namespace TaskMachine.Node
{


    internal class TaskClock : TaskNode
    {
        private float time;
        private Action isTime;

        private static ObjectPool<TaskClock> objectPool = TaskManager.GetPool<TaskClock>();

        internal static TaskClock Get(TaskProcess process, float time, Action isTime)
        {
            var node = objectPool.Get();
            node.process = process;
            node.time = time;
            node.isTime = isTime;
            return node;
        }


        public override void Update()
        {
            if (((DateTime.Now - process.ClockTime).TotalSeconds > time))
            {
                isTime();
                process.ToNext();
            }
        }
        public override void Recycle()
        {
            isTime = null;
            objectPool.Set(this);
        }

        public override void Dispose()
        {

        }


    }

}
namespace TaskMachine
{


    public partial class TaskProcess
    {
        public DateTime ClockTime = DateTime.MinValue;

        /// <summary>
        /// 闹钟刷新计时
        /// </summary>
        /// <returns></returns>
        public void ClockReset()
        {
            ClockTime = DateTime.Now;

        }

        /// <summary>
        /// 闹钟定时
        /// </summary>
        /// <param name="time">定时（秒）</param>
        /// <param name="isTime">响铃事件</param>
        /// <returns></returns>
        public TaskProcess ClockSet(float time, Action isTime)
        {
            Add(TaskClock.Get(this, time, isTime));
            return this;
        }
    }



}