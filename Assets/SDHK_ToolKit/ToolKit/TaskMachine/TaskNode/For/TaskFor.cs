


/******************************

 * 作者: 闪电黑客

 * 日期: 2021/02/22 10:08:09

 * 最后日期: 2021/02/23 15:30:31

 * 描述: 
    任务节点，继承TaskNode加入TaskProcess的任务队列进行执行。

    主要功能：
        给进程添加 For循环 功能

    设计目的:

        可随时在主进程开启一个For循环，可用于有延迟性质的循环调用。
    

******************************/



using System;
using TaskMachine.Node;

namespace TaskMachine.Node
{


    internal class TaskFor : TaskNode
    {

        private int i;

        private Func<int, bool> IF;

        private Func<int, int> action;
        private Func<int, TaskProcess, int> action_P;

        private static readonly ObjectPool<TaskFor> objectPool = TaskManager.GetPool<TaskFor>();

        internal static TaskFor Get(TaskProcess process, int i, Func<int, bool> IF, Func<int, int> action)
        {
            var node = objectPool.Get();

            node.process = process;
            node.i = i;
            node.IF = IF;
            node.action = action;

            return node;
        }

        internal static TaskFor Get(TaskProcess process, int i, Func<int, bool> IF, Func<int, TaskProcess, int> action)
        {
            var node = objectPool.Get();

            node.process = process;
            node.i = i;
            node.IF = IF;
            node.action_P = action;

            return node;
        }

        public override void Update()
        {

            if (IF(i))
            {
                if (action != null) i += action(i);
                if (action_P != null) i += action_P(i, process);
            }
            else
            {
                process.ToNext();
            }

        }

        public override void Recycle()
        {
            i = 0;
            IF = null;
            action = null;
            action_P = null;
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
        /// 循环：For循环
        /// </summary>
        /// <param name="i">起始值</param>
        /// <param name="IF">循环条件：True循环</param>
        /// <param name="action">循环委托：返回累加数值</param>
        /// <returns></returns>
        public TaskProcess For(int i, Func<int, bool> IF, Func<int, int> action)
        {
            Add(TaskFor.Get(this, i, IF, action));
            return this;
        }

        /// <summary>
        /// 循环：For循环(进程)
        /// </summary>
        /// <param name="i">起始值</param>
        /// <param name="IF">循环条件：True循环</param>
        /// <param name="action">循环委托：返回累加数值</param>
        /// <returns></returns>
        public TaskProcess For(int i, Func<int, bool> IF, Func<int, TaskProcess, int> action)
        {
            Add(TaskFor.Get(this, i, IF, action));
            return this;
        }
    }

}

