




/******************************

 * 作者: 闪电黑客

 * 日期: 2021/02/22 10:08:09

 * 最后日期: 2021/02/23 15:28:45

 * 描述: 
    任务节点，继承TaskNode加入TaskProcess的任务队列进行执行。

    主要功能：
        给进程添加 遍历List 功能

    设计目的：

        用于有延迟性质的 遍历调用。
        例如批量文件下载， 
        foreach功能可以开启子进程，等待文件下载完毕后，再遍历下载下一个。
        并且这个过程不会卡死主进程，导致unity卡死

******************************/


using System;
using System.Collections.Generic;
using TaskMachine.Node;

namespace TaskMachine.Node
{

    internal class TaskForeachList<T> : TaskNode
    {
        private List<T> list;
        private Action<T> action;
        private Action<T, TaskProcess> action_P;
        private int ForIndex;

        private static readonly ObjectPool<TaskForeachList<T>> objectPool = TaskManager.GetPool<TaskForeachList<T>>();


        internal static TaskForeachList<T> Get(TaskProcess process, List<T> list, Action<T> action)
        {
            var node = objectPool.Get();
            node.process = process;
            node.list = list;
            node.action = action;
            node.ForIndex = 0;

            return node;
        }

        internal static TaskForeachList<T> Get(TaskProcess process, List<T> list, Action<T, TaskProcess> action)
        {
            var node = objectPool.Get();
            node.process = process;
            node.list = list;
            node.action_P = action;
            node.ForIndex = 0;

            return node;
        }


        public override void Update()
        {
            if (ForIndex < list.Count)
            {
                if (action != null) action(list[ForIndex++]);
                if (action_P != null) action_P(list[ForIndex++], process);
            }
            else
            {
                process.ToNext();
            }

        }
        public override void Recycle()
        {
            list = null;
            ForIndex = 0;
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
        /// 遍历循环：List
        /// </summary>
        /// <param name="list">List</param>
        /// <param name="action">遍历委托</param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public TaskProcess Foreach<T>(List<T> list, Action<T> action)
        {
            Add(TaskForeachList<T>.Get(this, list, action));
            return this;
        }


        /// <summary>
        /// 遍历循环：List(进程)
        /// </summary>
        /// <param name="list">List</param>
        /// <param name="action">遍历委托</param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public TaskProcess Foreach<T>(List<T> list, Action<T, TaskProcess> action)
        {
            Add(TaskForeachList<T>.Get(this, list, action));
            return this;
        }
    }
}