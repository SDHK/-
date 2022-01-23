





/******************************

 * 作者: 闪电黑客

 * 日期: 2021/02/22 10:08:09

 * 最后日期: 2021/02/23 15:28:45

 * 描述: 
    任务节点，继承TaskNode加入TaskProcess的任务队列进行执行。

    主要功能：
        给进程添加 进程挂起暂停 的 功能

    设计目的：

        可以用于等待回调方法。

        Stop开启一个有回调的任务后， 进程会自己挂起。
        将Continue注册到回调事件上,
        当任务结束时回调Continue就会继续运行.

******************************/



using System;
using TaskMachine.Node;

namespace TaskMachine.Node
{
    internal class TaskStop : TaskNode
    {
        private TaskActuator taskActuator;

        private Action<TaskProcess> action;

        private static readonly ObjectPool<TaskStop> objectPool = TaskManager.GetPool<TaskStop>();

        internal static TaskStop Get(TaskProcess process, TaskActuator taskActuator, Action<TaskProcess> action)
        {
            var node = objectPool.Get();
            node.process = process;
            node.taskActuator = taskActuator;
            node.action = action;
            return node;
        }

        public override void Update()
        {
            taskActuator.StopTask(process);
            if (action != null) action(process);
            process.ToNext();
        }
        public override void Recycle()
        {
            taskActuator = null;
            action = null;
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
        /// 暂停挂起：挂起进程等待，回调(进程)
        /// </summary>
        /// <param name="action">事件</param>
        /// <returns></returns>
        public TaskProcess Stop(Action<TaskProcess> action)
        {
            Add(TaskStop.Get(this, taskActuator, action));
            return this;
        }

        /// <summary>
        /// 继续运行：恢复进程的运行
        /// </summary>
        public void Continue()
        {
            taskActuator.PlayTask(this);
        }
    }
}