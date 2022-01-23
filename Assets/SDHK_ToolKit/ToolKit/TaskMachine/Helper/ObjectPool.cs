


/******************************

 * 作者: 闪电黑客

 * 日期: 2021/03/01 09:44:29

 * 最后日期: 2021/03/06 13:25:30

 * 描述: 
    泛型对象池：用于回收对象进行重复利用

    【享元模式】

******************************/



using System;
using System.Collections.Generic;
using UnityEngine;


namespace TaskMachine
{

    /// <summary>
    /// 泛型对象池
    /// </summary>
    public class ObjectPool<T> : IDisposable, IObjectPool
    {

        /// <summary>
        /// 对象池
        /// </summary>
        private Queue<T> objects = new Queue<T>();

        /// <summary>
        /// 获取委托:获取后的回调函数
        /// </summary>
        private Action<T> onGet;

        /// <summary>
        /// 回收委托:回收后的回调函数
        /// </summary>
        private Action<T> onSet;


        private Func<T> newObject;//实例化对象的方法
        private Action<T> clearObject;//删除对象的方法


        /// <summary>
        /// 对象数量
        /// </summary>
        public int Count()
        {
            return objects.Count;
        }


        /// <summary>
        /// 初始化对象池
        /// </summary>
        /// <param name="New">实例化委托</param>
        public ObjectPool(Func<T> New)
        {
            newObject = New;
        }


        /// <summary>
        /// 设置获取时的初始化方法
        /// </summary>
        /// <returns>对象池</returns>
        public ObjectPool<T> GetObject(Action<T> onGet)
        {
            this.onGet = onGet;
            return this;
        }

        /// <summary>
        /// 设置回收时的回收方法
        /// </summary>
        /// <param name="onSet">回收方法（对象）</param>
        /// <returns>对象池</returns>
        public ObjectPool<T> SetObject(Action<T> onSet)
        {
            this.onSet = onSet;
            return this;
        }


        /// <summary>
        /// 设置清除对象的方法
        /// </summary>
        /// <param name="onClear">清除方法（对象）</param>
        /// <returns>对象池</returns>
        public ObjectPool<T> ClearObject(Action<T> onClear)
        {
            this.clearObject = onClear;
            return this;
        }




        /// <summary>
        /// 获取对象(传入参数)
        /// </summary>
        /// <returns>对象</returns>
        public T Get()
        {
            lock (this.objects)
            {
                T obj;

                if (objects.Count > 0)
                {
                    obj = objects.Dequeue();
                }
                else
                {
                    obj = newObject();
                }

                if (this.onGet != null)
                {
                    this.onGet(obj);
                }
                return obj;
            }
        }



        /// <summary>
        /// 回收对象
        /// </summary>
        /// <param name="Object">要回收的对象</param>
        public void Set(T Object)
        {
            lock (this.objects)
            {
                if (!objects.Contains(Object))
                {
                    objects.Enqueue(Object);

                    if (onSet != null) onSet(Object);
                }
                else
                {
                    Debug.Log("对象存在");
                }
            }
        }


        /// <summary>
        /// 清除对象
        /// </summary>
        /// <param name="Count">限制数量</param>
        public void Clear(int Count = 0)
        {
            lock (this.objects)
            {
                if (clearObject != null)
                {
                    while (objects.Count > Count)
                    {
                        var obj = objects.Dequeue();
                        clearObject(obj);
                    }
                }
            }
        }

        /// <summary>
        /// 释放
        /// </summary>
        public void Dispose()
        {
            Clear();
        }


    }


}