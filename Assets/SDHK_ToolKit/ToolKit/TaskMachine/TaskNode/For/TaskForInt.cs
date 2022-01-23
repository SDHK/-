/******************************

 * 作者: 闪电黑客

 * 日期: 2021/02/26 17:50:59

 * 最后日期: 2021/02/26 17:51:23

 * 描述: 
    任务节点，继承TaskNode加入TaskProcess的任务队列进行执行。

    主要功能：
        给进程添加 计数循环 功能

    设计目的：

        可随时在主进程开启一个 计数循环循环或逼近循环，也可用于有延迟性质的循环调用。

******************************/




using System;
using TaskMachine.Node;

namespace TaskMachine.Node
{

    internal class TaskForInt : TaskNode
    {
        private int i;
        private int target;
        private Action<int> action;
        private Action<int, TaskProcess> action_P;

        private static readonly ObjectPool<TaskForInt> objectPool = TaskManager.GetPool<TaskForInt>();


        internal static TaskForInt Get(TaskProcess process, int count)
        {
            var node = objectPool.Get();
            node.process = process;
            node.i = 0;
            node.target = count;
            node.action = null;

            return node;
        }

        internal static TaskForInt Get(TaskProcess process, int count, Action<int> action, int i = 0)
        {
            var node = objectPool.Get();
            node.process = process;
            node.i = i;
            node.target = count;
            node.action = action;

            return node;
        }

        internal static TaskForInt Get(TaskProcess process, int count, Action<int, TaskProcess> action, int i = 0)
        {
            var node = objectPool.Get();
            node.process = process;
            node.i = i;
            node.target = count;
            node.action_P = action;

            return node;
        }

        public override void Update()
        {
            if (target - i > 0)
            {
                if (action != null) action(i);
                if (action_P != null) action_P(i, process);
                i++;
            }
            else if (target - i < 0)
            {
                if (action != null) action(i);
                if (action_P != null) action_P(i, process);
                i--;
            }
            else
            {
                process.ToNext();
            }
        }

        public override void Recycle()
        {
            i = 0;
            target = 0;
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
        /// 循环：帧空转
        /// </summary>
        /// <param name="count">循环数</param>
        /// <param name="action">循环委托</param>
        /// <returns></returns>
        public TaskProcess For(int count)
        {
            Add(TaskForInt.Get(this, count));
            return this;
        }

        /// <summary>
        /// 循环：计数循环
        /// </summary>
        /// <param name="count">循环数</param>
        /// <param name="action">循环委托</param>
        /// <returns></returns>
        public TaskProcess For(int count, Action<int> action)
        {
            Add(TaskForInt.Get(this, count, action));
            return this;
        }


        /// <summary>
        /// 循环：计数循环(进程)
        /// </summary>
        /// <param name="count">循环数</param>
        /// <param name="action">循环委托</param>
        /// <returns></returns>
        public TaskProcess For(int count, Action<int, TaskProcess> action)
        {
            Add(TaskForInt.Get(this, count, action));
            return this;
        }

        /// <summary>
        /// 循环：逼近循环, 输出 i 到 target 但不包括target。例如（0,3）则从0 -> 2，（0，-3）则0 -> -2
        /// </summary>
        /// <param name="i">起始指</param>
        /// <param name="target">目标值</param>
        /// <param name="action">循环委托</param>
        /// <returns></returns>
        public TaskProcess For(int i, int target, Action<int> action)
        {
            Add(TaskForInt.Get(this, target, action, i));
            return this;
        }

        /// <summary>
        /// 循环：逼近循环（进程）, 输出 i 到target 但不包括target。例如（0,3）则从0 -> 2，（0，-3）则0 -> -2
        /// </summary>
        /// <param name="i">起始指</param>
        /// <param name="target">目标值</param>
        /// <param name="action">循环委托</param>
        /// <returns></returns>
        public TaskProcess For(int i, int target, Action<int, TaskProcess> action)
        {
            Add(TaskForInt.Get(this, target, action, i));
            return this;
        }
    }


}