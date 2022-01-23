/******************************

 * 作者: 闪电黑客

 * 日期: 2021/02/26 17:50:59

 * 最后日期: 2021/02/26 17:51:23

 * 描述: 
    任务节点，继承TaskNode加入TaskProcess的任务队列进行执行。

    主要功能：
        给进程添加 遍历链表 功能

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


    internal class TaskForeachLinkedList<T> : TaskNode
    {
        private LinkedList<T> linkedList;
        private Action<T> action;
        private Action<T, TaskProcess> action_P;
        private LinkedListNode<T> listNode = null;

        private static readonly ObjectPool<TaskForeachLinkedList<T>> objectPool = TaskManager.GetPool<TaskForeachLinkedList<T>>();
        internal static TaskForeachLinkedList<T> Get(TaskProcess process, LinkedList<T> linkedList, Action<T> action)
        {
            var node = objectPool.Get();
            node.process = process;
            node.linkedList = linkedList;
            node.action = action;

            return node;
        }

        internal static TaskForeachLinkedList<T> Get(TaskProcess process, LinkedList<T> linkedList, Action<T, TaskProcess> action)
        {
            var node = objectPool.Get();
            node.process = process;
            node.linkedList = linkedList;
            node.action_P = action;

            return node;
        }


        public override void Update()
        {
            if (listNode == null)
            {
                if (linkedList.First != null)
                {
                    listNode = linkedList.First;
                    if (action != null) action(linkedList.First.Value);
                    if (action_P != null) action_P(linkedList.First.Value, process);
                }
                else
                {
                    ToNext();
                }
            }
            else
            {
                if (listNode.Next != null)
                {
                    listNode = listNode.Next;
                    if (action != null) action(linkedList.First.Value);
                    if (action_P != null) action_P(linkedList.First.Value, process);
                }
                else
                {
                    ToNext();
                }
            }
        }

        private void ToNext()
        {
            process.ToNext();
        }

        public override void Recycle()
        {
            linkedList = null;
            listNode = null;
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
        /// 遍历循环：链表
        /// </summary>
        /// <param name="linkedList">链表</param>
        /// <param name="action">遍历委托</param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public TaskProcess Foreach<T>(LinkedList<T> linkedList, Action<T> action)
        {
            Add(TaskForeachLinkedList<T>.Get(this, linkedList, action));
            return this;
        }


        /// <summary>
        /// 遍历循环：链表(进程)
        /// </summary>
        /// <param name="linkedList">链表</param>
        /// <param name="action">遍历委托</param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public TaskProcess Foreach<T>(LinkedList<T> linkedList, Action<T, TaskProcess> action)
        {
            Add(TaskForeachLinkedList<T>.Get(this, linkedList, action));
            return this;
        }

    }


}