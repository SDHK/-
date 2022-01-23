





/******************************

 * 作者: 闪电黑客

 * 日期: 2021/02/22 10:08:09

 * 最后日期: 2021/02/23 15:27:06

 * 描述: 
    任务节点，继承TaskNode加入TaskProcess的任务队列进行执行。

    主要功能：给进程添加普通委托功能

    设计目的：
        控制流程顺序，以及方便随时随地 让函数在 下一帧 执行

******************************/






using System;
using TaskMachine.Node;

namespace TaskMachine.Node
{



    internal class TaskEvent : TaskNode
    {
        private Action action;
        private Action<TaskProcess> action_P;

        private static readonly ObjectPool<TaskEvent> objectPool = TaskManager.GetPool<TaskEvent>();

        internal static TaskEvent Get(TaskProcess process, Action action)
        {
            var node = objectPool.Get();
            node.process = process;
            node.action = action;

            return node;
        }

        internal static TaskEvent Get(TaskProcess process, Action<TaskProcess> action)
        {
            var node = objectPool.Get();
            node.process = process;
            node.action_P = action;

            return node;
        }

        public override void Update()
        {
            if (action != null) action();
            if (action_P != null) action_P(process);
            process.ToNext();//通知当前进程到下一个
        }


        public override void Recycle()
        {
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
        /// 事件
        /// </summary>
        /// <param name="action">委托事件</param>
        /// <returns></returns>
        public TaskProcess Event(Action action)
        {
            Add(TaskEvent.Get(this, action));

            return this;
        }



        /// <summary>
        /// 事件(进程)
        /// </summary>
        /// <param name="action">委托事件</param>
        /// <returns></returns>
        public TaskProcess Event(Action<TaskProcess> action)
        {
            Add(TaskEvent.Get(this, action));

            return this;
        }
    }









}