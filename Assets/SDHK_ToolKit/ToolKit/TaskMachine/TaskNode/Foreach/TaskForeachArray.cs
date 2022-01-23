/******************************

 * 作者: 闪电黑客

 * 日期: 2021/02/26 17:50:59

 * 最后日期: 2021/02/26 17:51:23

 * 描述: 
    任务节点，继承TaskNode加入TaskProcess的任务队列进行执行。

    主要功能：
        给进程添加 遍历数组 功能

    设计目的：

        用于有延迟性质的 遍历调用。
        例如批量文件下载， 
        foreach功能可以开启子进程，等待文件下载完毕后，再遍历下载下一个。
        并且这个过程不会卡死主进程，导致unity卡死

******************************/




using System;
using TaskMachine.Node;

namespace TaskMachine.Node
{

    internal class TaskForeachArray<T> : TaskNode
    {
        private T[] array;
        private Action<T> action;
        private Action<T, TaskProcess> action_P;
        private int ForIndex;


        internal static readonly ObjectPool<TaskForeachArray<T>> objectPool = TaskManager.GetPool<TaskForeachArray<T>>();

        internal static TaskForeachArray<T> Get(TaskProcess process, T[] array, Action<T> action)
        {
            var node = objectPool.Get();
            node.process = process;
            node.array = array;
            node.action = action;
            node.ForIndex = 0;

            return node;

        }

        internal static TaskForeachArray<T> Get(TaskProcess process, T[] array, Action<T, TaskProcess> action)
        {
            var node = objectPool.Get();

            return node;
        }
        public override void Update()
        {
            if (ForIndex < array.Length)
            {
                if (action != null) action(array[ForIndex++]);
                if (action_P != null) action_P(array[ForIndex++], process);
            }
            else
            {
                process.ToNext();
            }
        }

        public override void Recycle()
        {
            ForIndex = 0;
            array = null;
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
        /// 遍历循环：数组
        /// </summary>
        /// <param name="array">数组</param>
        /// <param name="action">遍历委托</param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public TaskProcess Foreach<T>(T[] array, Action<T> action)
        {
            Add(TaskForeachArray<T>.Get(this, array, action));
            return this;
        }

        /// <summary>
        /// 遍历循环：数组(进程)
        /// </summary>
        /// <param name="array">数组</param>
        /// <param name="action">遍历委托</param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public TaskProcess Foreach<T>(T[] array, Action<T, TaskProcess> action)
        {
            Add(TaskForeachArray<T>.Get(this, array, action));
            return this;
        }
    }

}