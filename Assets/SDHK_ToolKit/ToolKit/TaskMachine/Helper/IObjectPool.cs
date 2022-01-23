using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TaskMachine
{
    /// <summary>
    /// 对象池接口
    /// </summary>
    public interface IObjectPool
    {
        /// <summary>
        /// 获取对象数量
        /// </summary>
        int Count();
    }
}