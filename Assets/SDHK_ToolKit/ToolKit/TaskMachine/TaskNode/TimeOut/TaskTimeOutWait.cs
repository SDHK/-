





/******************************

 * 作者: 闪电黑客

 * 日期: 2021/02/22 10:08:09

 * 最后日期: 2021/02/23 15:28:45

 * 描述: 
    任务节点，继承TaskNode加入TaskProcess的任务队列进行执行。

    主要功能：
        给进程添加 超时检测 功能

    设计目的：

        计时到了指定时间,解除阻塞并且回调
        mark检测返回为true,会立即解除阻塞并回调

        可用于等待下载或者等待操作，假如超时则直接跳过。

******************************/




using System;
using TaskMachine.Node;

namespace TaskMachine.Node
{

    internal class TaskTimeOutWait : TaskNode
    {
        private float time;
        private Func<bool> mark;
        private Action<bool> timeout;
        private DateTime SystemTime;

        internal static readonly ObjectPool<TaskTimeOutWait> objectPool = TaskManager.GetPool<TaskTimeOutWait>();

        internal static TaskTimeOutWait Get(TaskProcess process, float time, Func<bool> mark, Action<bool> timeout = null)
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
            if (SystemTime == DateTime.MinValue)
            {
                SystemTime = DateTime.Now;
            }

            bool isTime = ((DateTime.Now - SystemTime).TotalSeconds > time);

            if (isTime || mark())
            {
                if (timeout != null) timeout(isTime);
                process.ToNext();
            }
        }

        public override void Recycle()
        {
            mark = null;
            timeout = null;
            objectPool.Set(this);//完毕后，让全局对象池回收自己
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
        /// 超时等待：
        ///     计时到了指定时间,解除阻塞并且回调
        ///     mark检测返回为true,解除阻塞并回调
        ///     
        /// 回调参数为true则为超时回调
        ///     
        /// </summary>
        /// <param name="time">时间（秒）</param>
        /// <param name="mark">监测标记</param>
        /// <param name="timeout">超时回调（true为超时）</param>
        /// <returns></returns>
        public TaskProcess TimeOutWait(float time, Func<bool> mark, Action<bool> timeout = null)
        {

            Add(TaskTimeOutWait.Get(this, time, mark, timeout));

            return this;
        }

    }
}