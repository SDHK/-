/******************************

 * 作者: 闪电黑客

 * 日期: 2021/10/06 0:16:37

 * 最后日期: 。。。

 * 描述: 
 
    泛型对象池 ，包含 限制数，预加载，无操作倒计时回收 功能

    其中 计时功能 需要注册到 Manager 管理器里才能运作，
    在无操作一定时间后，对象池将被直接清空。


    池内对象数量超过 maxCount 时，对象将不再被回收，而是被销毁。

    当 maxCount ==-1 时，则不限制对象数量。


    预加载功能 在对象池新建时，和 每次Get对象后，将数量保持在预加载数。
    也可在清空后，主动调用预加载函数。


    对象池会尝试判断，对象是否继承 IObjectPoolItem，并调用其方法。

    
******************************/


using System;
using System.Collections.Generic;

namespace ObjectPool_
{

    /// <summary>
    /// 泛型对象池
    /// </summary>
    public class ObjectPool<T> : ObjectPoolBase
    where T : class
    {

        /// <summary>
        /// 对象池
        /// </summary>
        private Queue<T> objetPool = new Queue<T>();

        public override int Count { get => objetPool.Count; }


        public override T1 Get<T1>()
        {
            return Get() as T1;
        }

        /// <summary>
        /// 获取对象
        /// </summary>
        public T Get()
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
                        (obj as IObjectPoolItem)?.ObjectOnGet();
                        Preload();
                        return obj;
                    }
                }

                // obj = new T();
                obj = Activator.CreateInstance(typeof(T), true) as T;
                if (obj is IObjectPoolItem)
                {
                    var obj_ = (obj as IObjectPoolItem);
                    obj_.ObjectOnNew();
                    obj_.ObjectOnGet();
                }

                Preload();
                return obj;
            }
        }



        public override void Recycle(object obj)
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
                            (obj as IObjectPoolItem)?.ObjectOnRecycle();
                        }
                    }
                    else
                    {
                        (obj as IObjectPoolItem)?.ObjectOnRecycle();
                        (obj as IObjectPoolItem)?.ObjectOnClear();
                    }
                }
            }
        }

        public override void Clear()
        {
            lock (objetPool)
            {
                for (int i = objetPool.Count - 1; i >= 0; i--)
                {
                    var obj = objetPool.Dequeue();
                    (obj as IObjectPoolItem)?.ObjectOnRecycle();
                    (obj as IObjectPoolItem)?.ObjectOnClear();
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
                    // T obj = new T();
                    T obj = Activator.CreateInstance(typeof(T), true) as T;
                    objetPool.Enqueue(obj);
                    (obj as IObjectPoolItem)?.ObjectOnNew();
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






