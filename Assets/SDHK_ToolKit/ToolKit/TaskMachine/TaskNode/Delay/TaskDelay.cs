



/******************************

 * 作者: 闪电黑客

 * 日期: 2021/02/24 10:01:52

 * 最后日期: 2021/02/24 10:04:30

 * 描述: 
    任务节点，继承TaskNode加入TaskProcess的任务队列进行执行。

    主要功能：
        给进程添加 延时等待 功能

    设计目的：

        让进程可以运行在 主进程中 拥有 线程一样延迟运行功能 ，并不会卡死主线程

******************************/



using System;
using TaskMachine.Node;

namespace TaskMachine.Node
{

    internal class TaskDelay : TaskNode
    {
        private float time;

        private Action<double> timing;

        private DateTime SystemTime;

        private static readonly ObjectPool<TaskDelay> objectPool = TaskManager.GetPool<TaskDelay>();

        internal static TaskDelay Get(TaskProcess process, float time, Action<double> timing = null)
        {
            var node = objectPool.Get();
            node.process = process;
            node.time = time;
            node.timing = timing;
            node.SystemTime = DateTime.MinValue;

            return node;
        }


        public override void Update()
        {
            if (SystemTime == DateTime.MinValue)
            {
                SystemTime = DateTime.Now;
            }

            double Seconds = (DateTime.Now - SystemTime).TotalSeconds;
            if (timing != null) timing(Seconds);

            if ((Seconds > time))
            {
                SystemTime = DateTime.MinValue;
                process.ToNext();
            }
        }

        public override void Recycle()
        {
            timing = null;
            objectPool.Set(this);//完毕后，让全局对象池回收自己
        }

        public override void Dispose()
        {
            timing = null;
        }

    }

}
namespace TaskMachine
{



    public partial class TaskProcess
    {
        /// <summary>
        /// 延时一段时间（秒）
        /// </summary>
        /// <param name="time">时间（秒）</param>
        /// <returns></returns>
        public TaskProcess Delay(float time)
        {
            Add(TaskDelay.Get(this, time));

            return this;

        }

        /// <summary>
        /// 延时一段时间（秒），每帧计时回调 
        /// </summary>
        /// <param name="time">时间（秒）</param>
        /// <param name="timing">计时回调</param>
        /// <returns></returns>
        public TaskProcess Delay(float time, Action<double> timing)
        {
            Add(TaskDelay.Get(this, time, timing));

            return this;

        }

    }






}