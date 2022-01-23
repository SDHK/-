using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ObjectPool_;
public class ObjectPoolTest : IObjectPoolItem
{

    public static ObjectPool<ObjectPoolTest> pool = new ObjectPool<ObjectPoolTest>()
    { clock = 10, maxCount = 100, preloadCount = 1 }// 这行可以直接删除不写。不写默认无倒计时，不限制数量，预加载为0
    .RegisterManager();//注册到管理器，管理器提供计了时刷新，没有注册到管理器则计时功能失效


    public void ObjectOnNew()
    {
        Debug.Log("对象新建");
    }
    public void ObjectOnClear()
    {
        Debug.Log("对象删除");
    }

    public void ObjectOnGet()
    {
        Debug.Log("对象获取");
    }
    public void ObjectOnRecycle()
    {
        Debug.Log("对象回收");
    }


}
