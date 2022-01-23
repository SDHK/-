/******************************

 * 作者: 闪电黑客

 * 日期: 2021/10/06 0:16:37

 * 最后日期: 2021/10/16 4:12:00

 * 描述: 
 
    泛型对象池总管理器

    管理 继承了 ObjectPoolBase 的泛型对象池

    提供一个全局的Mono单例

    主要功能:遍历所有 ObjectPoolBase 的 Update()，刷新倒计时
    
******************************/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Singleton;

namespace ObjectPool_
{

    /// <summary>
    /// 泛型对象池管理器
    /// </summary>
    public class ObjectPoolManager : SingletonMonoBase<ObjectPoolManager>
    {

        private Dictionary<Type, ObjectPoolBase> objectPools = new Dictionary<Type, ObjectPoolBase>();


        /// <summary>
        /// 注册对象池
        /// </summary>
        public ObjectPool<T> Register<T>(ObjectPool<T> pool)
        where T : class
        {
            if (!objectPools.ContainsKey(typeof(T)))
            {
                objectPools.Add(typeof(T), pool);
            }
            return pool;
        }



        private void Update()
        {
            foreach (var pool in objectPools)
            {
                pool.Value.Update(Time.deltaTime);
            }
        }
    }







}