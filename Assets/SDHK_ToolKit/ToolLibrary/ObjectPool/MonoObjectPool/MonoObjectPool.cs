
/******************************

 * 作者: 闪电黑客

 * 日期: 2021/10/16 4:16:30

 * 最后日期: 。。。

 * 描述: 
 
    Mono泛型对象池，包含 限制数，预加载，无操作倒计时回收 功能

    其中 计时功能 需要注册到 Manager 管理器里才能运作，
    在无操作一定时间后，对象池将被直接清空。


    池内对象数量超过 maxCount 时，对象将不再被回收，而是被销毁。

    当 maxCount ==-1 时，则不限制对象数量。


    预加载功能 在对象池新建时，和 每次Get对象后，将数量保持在预加载数。
    也可在清空后，主动调用预加载函数。


    对象池会尝试判断，组件类型是否继承 IMonoObjectPoolItem，并调用其方法。


    负责 继承Mono的游戏组件 类型，

    主要解决  游戏物体 + 组件  绑定的对象池

    控制重点是 Mono组件 ,而不是GameObject


    组件类型 和 预制体 只能在对象池新建时传入 ，不可修改



******************************/

using System.Collections.Generic;
using UnityEngine;


namespace ObjectPool_
{

    /// <summary>
    /// Mono泛型对象池
    /// </summary>
    public class MonoObjectPool<T> : MonoObjectPoolBase
    where T : MonoBehaviour
    {

        private Queue<T> objetPool = new Queue<T>();

        public override int Count => objetPool.Count;


        /// <summary>
        /// 新建对象池
        /// </summary>
        /// <param name="type">对象类型</param>
        /// <param name="prefabObj">绑定的预制体</param>
        public MonoObjectPool(GameObject prefabObj = null)
        {
            monoType = typeof(T);
            if (prefabObj != null)
            {
                prefab = prefabObj;
                objName = monoType.Name + ":" + prefabObj.name;
            }
            else
            {
                objName = monoType.Name;
            }

            poolTransform = new GameObject(objName + " Pool").transform;
            GameObject.DontDestroyOnLoad(poolTransform.gameObject);
        }

        private T NewObject()
        {
            GameObject gameObj = (prefab == null) ? new GameObject(objName) : GameObject.Instantiate(prefab);
            return gameObj.AddComponent<T>();
        }


        public override T1 Get<T1>(Transform parent = null)
        {
            return Get(parent) as T1;
        }

        /// <summary>
        /// 获取一个Mono对象
        /// </summary>
        public T Get(Transform parent = null)
        {
            lock (objetPool)
            {
                clocktime = clock;

                T obj;
                while (objetPool.Count > 0)
                {
                    obj = objetPool.Dequeue();
                    if (obj != null)
                    {
                        obj.transform.SetParent(parent);
                        obj.gameObject.SetActive(true);
                        (obj as IMonoObjectPoolItem)?.ObjectOnGet();

                        Preload();
                        return obj;
                    }
                }

                obj = NewObject();
                obj.transform.SetParent(parent);
                obj.gameObject.SetActive(true);
                if (obj is IMonoObjectPoolItem)
                {
                    var IObj = (obj as IMonoObjectPoolItem);
                    IObj.RecyclePool = this;
                    IObj.ObjectOnNew();
                    IObj.ObjectOnGet();
                }
                Preload();

                return obj;
            }
        }

        public override void Recycle(MonoBehaviour obj)
        {
            lock (objetPool)
            {
                clocktime = clock;
                if (obj != null)
                {
                    if (maxCount == -1 || objetPool.Count < maxCount)
                    {
                        if (!objetPool.Contains(obj as T))
                        {
                            objetPool.Enqueue(obj as T);
                            (obj as IMonoObjectPoolItem)?.ObjectOnRecycle();
                            obj.gameObject.SetActive(false);
                            obj.transform.SetParent(poolTransform);
                        }
                    }
                    else
                    {
                        (obj as IMonoObjectPoolItem)?.ObjectOnRecycle();
                        (obj as IMonoObjectPoolItem)?.ObjectOnClear();
                        GameObject.Destroy(obj.gameObject);
                    }
                }
            }
        }

        public override void Clear()
        {
            lock (objetPool)
            {
                while (objetPool.Count != 0)
                {
                    var monoObj = objetPool.Dequeue();
                    if (monoObj != null)
                    {
                        (monoObj as IMonoObjectPoolItem)?.ObjectOnRecycle();
                        (monoObj as IMonoObjectPoolItem)?.ObjectOnClear();
                        GameObject.Destroy(monoObj.gameObject);
                    }
                }
                objetPool.Clear();
            }
        }

        public override void Preload()
        {
            lock (objetPool)
            {
                while (objetPool.Count < preloadCount)
                {

                    T MonoObj = NewObject();
                    objetPool.Enqueue(MonoObj);
                    MonoObj.transform.SetParent(poolTransform);
                    MonoObj.gameObject.SetActive(false);
                    if (MonoObj is IMonoObjectPoolItem)
                    {
                        var monoObject = (MonoObj as IMonoObjectPoolItem);
                        monoObject.RecyclePool = this;
                        monoObject.ObjectOnNew();
                    }

                }
            }
        }

        public override void Update(float deltaTime)
        {
            if (clocktime != -1)
            {
                if (clocktime > 0)
                {
                    clocktime -= deltaTime;
                }
                else
                {
                    Clear();
                    clocktime = -1;
                }
            }
        }


    }




}