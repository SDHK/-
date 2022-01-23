




/******************************

 * 作者: 闪电黑客

 * 日期: 2021/02/22 10:08:09

 * 最后日期: 2021/02/23 15:30:31

 * 描述: 
    任务节点，继承TaskNode加入TaskProcess的任务队列进行执行。

    主要功能：
        给进程添加 while循环 功能

    设计目的:

        可随时在主进程开启 死循环或者 while条件循环，可用于有延迟性质的循环调用。
    

******************************/






using System;
using TaskMachine.Node;

namespace TaskMachine.Node
{
    
    internal class TaskWhile : TaskNode
    {
        private Func<bool> IF;
        private Action action;
        private Action<TaskProcess> action_P;

        private static readonly ObjectPool<TaskWhile> objectPool = TaskManager.GetPool<TaskWhile>();

        internal static TaskWhile Get(TaskProcess process, Func<bool> IF, Action action)
        {
            var node = objectPool.Get();

            node.process = process;
            node.IF = IF;
            node.action = action;

            return node;
        }

        internal static TaskWhile Get(TaskProcess process, Func<bool> IF, Action<TaskProcess> action)
        {
            var node = objectPool.Get();

            node.process = process;
            node.IF = IF;
            node.action_P = action;

            return node;
        }

        public override void Update()
        {
            if (IF())
            {
                if (action != null) action();
                if (action_P != null) action_P(process);
            }
            else
            {
                process.ToNext();
            }
        }

        public override void Recycle()
        {
            IF = null;
            action = null;
            action_P = null;
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
        /// 循环：死循环(进程)
        /// </summary>
        /// <param name="action">死循环委托</param>
        /// <returns></returns>
        public TaskProcess For(Action<TaskProcess> action)
        {
            Add(TaskWhile.Get(this, () => true, action));
            return this;
        }


        /// <summary>
        /// 循环：条件循环
        /// </summary>
        /// <param name="IF">循环条件：True循环</param>
        /// <param name="action">循环委托</param>
        /// <returns></returns>
        public TaskProcess While(Func<bool> IF, Action action)
        {
            Add(TaskWhile.Get(this, IF, action));
            return this;
        }

        /// <summary>
        /// 循环：条件循环(进程)
        /// </summary>
        /// <param name="IF">循环条件：True循环</param>
        /// <param name="action">循环委托</param>
        /// <returns></returns>
        public TaskProcess While(Func<bool> IF, Action<TaskProcess> action)
        {
            Add(TaskWhile.Get(this, IF, action));
            return this;
        }

    }


}