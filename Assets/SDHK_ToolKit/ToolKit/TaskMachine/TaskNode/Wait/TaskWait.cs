


/******************************

 * 作者: 闪电黑客

 * 日期: 2021/02/22 10:08:09

 * 最后日期: 2021/02/23 15:31:26

 * 描述: 
    任务节点，继承TaskNode加入TaskProcess的任务队列进行执行。

    主要功能：
        给进程添加 条件等待 功能

    设计目的
    
        在主线程中阻塞检测条件，阻塞等待回调，并且不会卡死主进程。

******************************/



using System;
using TaskMachine.Node;

namespace TaskMachine.Node
{

    internal class TaskWait : TaskNode
    {
        private Func<bool> IF;
        private Action callback;

        private static readonly ObjectPool<TaskWait> objectPool = TaskManager.GetPool<TaskWait>();

        internal static TaskWait Get(TaskProcess process, Func<bool> IF, Action callback = null)
        {
            var node = objectPool.Get();
            node.process = process;
            node.IF = IF;
            node.callback = callback;
            return node;
        }
        public override void Update()
        {
            if (IF())
            {
                if (callback != null) callback();
                process.ToNext();
            }
        }

        public override void Recycle()
        {
            IF = null;
            callback = null;
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
        /// 等待：条件判断
        /// </summary>
        /// <param name="IF">委托条件</param>
        /// <returns></returns>
        public TaskProcess Wait(Func<bool> IF)
        {
            Add(TaskWait.Get(this, IF));
            return this;
        }



        /// <summary>
        /// 等待：条件判断，回调
        /// </summary>
        /// <param name="IF">委托条件</param>
        /// <param name="callback">回调</param>
        /// <returns></returns>
        public TaskProcess Wait(Func<bool> IF, Action callback)
        {
            Add(TaskWait.Get(this, IF, callback));
            return this;
        }



    }




}