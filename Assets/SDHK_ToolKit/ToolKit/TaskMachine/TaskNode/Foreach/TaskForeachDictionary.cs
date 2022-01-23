/******************************

 * 作者: 闪电黑客

 * 日期: 2021/02/26 17:50:59

 * 最后日期: 2021/02/26 17:51:23

 * 描述: 
    任务节点，继承TaskNode加入TaskProcess的任务队列进行执行。

    主要功能：
        给进程添加 遍历字典 功能

    设计目的：

        用于有延迟性质的 遍历调用。
        例如批量文件下载， 
        foreach功能可以开启子进程，等待文件下载完毕后，再遍历下载下一个。
        并且这个过程不会卡死主进程，导致unity卡死

******************************/




using System;
using System.Collections.Generic;
using System.Linq;
using TaskMachine.Node;

namespace TaskMachine.Node
{


    internal class TaskForeachDictionary<key, value> : TaskNode
    {
        private Dictionary<key, value> dictionary;
        private Action<key, value> action;
        private Action<key, value, TaskProcess> action_P;
        private int ForIndex;

        private static readonly ObjectPool<TaskForeachDictionary<key, value>> objectPool = TaskManager.GetPool<TaskForeachDictionary<key, value>>();

        internal static TaskForeachDictionary<key, value> Get(TaskProcess process, Dictionary<key, value> dictionary, Action<key, value> action)
        {
            var node = objectPool.Get();
            node.ForIndex = 0;
            node.process = process;
            node.dictionary = dictionary;
            node.action = action;
            return node;
        }

        internal static TaskForeachDictionary<key, value> Get(TaskProcess process, Dictionary<key, value> dictionary, Action<key, value, TaskProcess> action)
        {
            var node = objectPool.Get();
            node.ForIndex = 0;
            node.process = process;
            node.dictionary = dictionary;
            node.action_P = action;
            return node;
        }

        public override void Update()
        {
            if (ForIndex < dictionary.Keys.Count)
            {
                key key = dictionary.Keys.ToList()[ForIndex++];

                if (action != null) action(key, dictionary[key]);
                if (action_P != null) action_P(key, dictionary[key], process);
            }
            else
            {
                process.ToNext();
            }
        }

        public override void Recycle()
        {
            dictionary = null;
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
        /// 遍历循环：字典
        /// </summary>
        /// <param name="dictionary">字典</param>
        /// <param name="action">遍历委托</param>
        /// <typeparam name="key">键</typeparam>
        /// <typeparam name="value">值</typeparam>
        /// <returns></returns>
        public TaskProcess Foreach<key, value>(Dictionary<key, value> dictionary, Action<key, value> action)
        {
            Add(TaskForeachDictionary<key, value>.Get(this, dictionary, action));
            return this;
        }


        /// <summary>
        /// 遍历循环：字典(进程)
        /// </summary>
        /// <param name="dictionary">字典</param>
        /// <param name="action">遍历委托</param>
        /// <typeparam name="Key">键</typeparam>
        /// <typeparam name="value">值</typeparam>
        /// <returns></returns>
        public TaskProcess Foreach<key, value>(Dictionary<key, value> dictionary, Action<key, value, TaskProcess> action)
        {
            Add(TaskForeachDictionary<key, value>.Get(this, dictionary, action));
            return this;
        }
    }

}