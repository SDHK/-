using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ObjectPool_
{
    public static class ObjectPoolExtenison
    {
        /// <summary>
        /// 注册泛型对象池 到管理器
        /// </summary>
        public static ObjectPool<T> RegisterManager<T>(this ObjectPool<T> objectPool)
        where T : class
        {
            return ObjectPoolManager.Instance().Register(objectPool);
        }
    }
}