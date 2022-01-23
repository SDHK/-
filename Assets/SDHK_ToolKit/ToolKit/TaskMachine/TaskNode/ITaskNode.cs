



/***********************************

 * 作者: 闪电黑客

 * 日期: 2021/03/07  17:45:04

 * 最后日期: 2021/03/07  17:45:11

 * 描述: 
 
    任务节点统一接口，
    
    继承接口可作为任务节点添加进任务队列运行

***********************************/



using System;


namespace TaskMachine.Node
{

    /// <summary>
    /// 任务执行节点接口
    /// </summary>
    public abstract class TaskNode : IDisposable
    {
        protected TaskProcess process;

        /// <summary>
        /// 执行
        /// </summary>
        public abstract void Update();

        /// <summary>
        /// 回收
        /// </summary>
        public abstract void Recycle();

        /// <summary>
        /// 释放
        /// </summary>
        public abstract void Dispose();



    }

}