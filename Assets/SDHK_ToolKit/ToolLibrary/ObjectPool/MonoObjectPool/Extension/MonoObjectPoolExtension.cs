using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ObjectPool_
{
    public static class MonoObjectPoolExtension
    {
        /// <summary>
        /// 注册Mono对象池 到管理器
        /// </summary>
        public static MonoObjectPool<T> RegisterManager<T>(this MonoObjectPool<T> objectPool)
        where T : MonoBehaviour
        {
            return MonoObjectPoolManager.Instance().Register(objectPool);
        }
    }
}