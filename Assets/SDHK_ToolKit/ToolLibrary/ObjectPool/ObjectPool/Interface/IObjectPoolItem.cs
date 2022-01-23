using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ObjectPool_
{
    /// <summary>
    /// 对象池对象接口
    /// </summary>
    public interface IObjectPoolItem
    {
       
        /// <summary>
        /// 对象新建时
        /// </summary>
        void ObjectOnNew();

        /// <summary>
        /// 对象获取时
        /// </summary>
        void ObjectOnGet();

        /// <summary>
        /// 对象回收时
        /// </summary>
        void ObjectOnRecycle();

        /// <summary>
        /// 对象删除时
        /// </summary>
        void ObjectOnClear();
    }

}