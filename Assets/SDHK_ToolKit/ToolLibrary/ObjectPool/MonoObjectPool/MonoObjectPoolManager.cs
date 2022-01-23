/******************************

 * 作者: 闪电黑客

 * 日期: 2021/10/16 4:12:00

 * 最后日期: 2021/10/16 4:12:00

 * 描述: 
 
    Mono泛型对象池总管理器

    管理 MonoObjectPoolBase

    提供一个全局的Mono单例

    主要功能:遍历所有 MonoObjectPoolBase 的 Update()，刷新倒计时
    
******************************/


using System.Collections;
using System.Collections.Generic;
using Singleton;
using UnityEngine;
namespace ObjectPool_
{

    public class MonoObjectPoolManager : SingletonMonoBase<MonoObjectPoolManager>
    {
        private List<MonoObjectPoolBase> objectPools = new List<MonoObjectPoolBase>();


        /// <summary>
        /// 注册Mono对象池
        /// </summary>
        public MonoObjectPool<T> Register<T>(MonoObjectPool<T> pool)
        where T : MonoBehaviour
        {
            if (!objectPools.Contains(pool))
            {
                objectPools.Add(pool);
                pool.poolTransform.SetParent(transform);
            }
            return pool;
        }


        private void Update()
        {

            foreach (var pool in objectPools)
            {
                pool.Update(Time.deltaTime);
            }
        }

    }
}