





/******************************

 * 作者: 闪电黑客

 * 日期: 2021/02/22 10:08:09

 * 最后日期: 2021/02/23 15:28:45

 * 描述: 
    任务节点，继承TaskNode加入TaskProcess的任务队列进行执行。

    主要功能：

        给进程添加 心跳检测 功能

    设计目的：

        当条件为 true 时会一直重置计时器，对进程进行阻塞
        用于检测链接断开或者无人操作

******************************/




using System;
using TaskMachine.Node;

namespace TaskMachine.Node
{


    internal class TaskTimeOutReset : TaskNode
    {
        private float time;
        private Func<bool> mark;
        private Action timeout;
        private DateTime SystemTime;

        private static readonly ObjectPool<TaskTimeOutReset> objectPool = TaskManager.GetPool<TaskTimeOutReset>();


        internal static TaskTimeOutReset Get(TaskProcess process, float time, Func<bool> mark, Action timeout = null)
        {
            var node = objectPool.Get();
            node.process = process;
            node.time = time;
            node.mark = mark;
            node.timeout = timeout;
            node.SystemTime = DateTime.MinValue;

            return node;
        }

        public override void Update()
        {
            if (SystemTime == DateTime.MinValue || mark())
            {
                SystemTime = DateTime.Now;
            }

            if ((DateTime.Now - SystemTime).TotalSeconds > time)
            {
                if (timeout != null) timeout();
                process.ToNext();
            }
        }

        public override void Recycle()
        {
            mark = null;
            timeout = null;
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
        /// <summary>
        /// 超时重置：
        ///     计时到了指定时间,解除阻塞并且回调
        ///     mark检测返回为true,重置计时
        /// 
        /// </summary>
        /// <param name="time">时间（秒）</param>
        /// <param name="mark">监测标记</param>
        /// <param name="timeout">超时回调</param>
        /// <returns></returns>
        public TaskProcess TimeOutReset(float time, Func<bool> mark, Action timeout = null)
        {
            Add(TaskTimeOutReset.Get(this, time, mark, timeout));

            return this;
        }

    }
}