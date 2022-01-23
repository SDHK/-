using System.Collections;
using System.Collections.Generic;
using ObjectPool_;
using UnityEngine;

public class MonoObjectPoolTest : MonoBehaviour, IMonoObjectPoolItem
{
    public static GameObject prefabObject;

    public MonoObjectPoolBase RecyclePool { get; set; }//回收用的回收池（用于解决同一个脚本绑定多个预制体的情况）

    public static MonoObjectPool<MonoObjectPoolTest> CubePool = new MonoObjectPool<MonoObjectPoolTest>(MonoObjectPoolResources.Instance().prefabCube)//这需要自己写，获取自己的静态对象池
    { clock = 10, maxCount = 20, preloadCount = 1 }// 这行可以直接删除不写。不写默认无倒计时，不限制数量，预加载为0
    .RegisterManager();//注册到管理器，管理器提供计了时刷新，没有注册到管理器则计时功能失效

    public static MonoObjectPool<MonoObjectPoolTest> SpherePool = new MonoObjectPool<MonoObjectPoolTest>(MonoObjectPoolResources.Instance().prefabSphere)//绑定的第二个不同的预制体
    { clock = 10, maxCount = 20, preloadCount = 1 }
    .RegisterManager();



    public float testTime;//假如是子弹，自动销毁倒计时

    private void Update()
    {
        testTime -= Time.deltaTime;
        if (testTime < 0)
        {
            RecyclePool.Recycle(this);//回收
        }
    }
    public void Recycle()//这需要自己写,让对象池回收自己,只是为了方便,也可以不写。
    {
        RecyclePool.Recycle(this);
    }

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
        testTime = 5;//设定5秒
    }
    public void ObjectOnRecycle()
    {
        Debug.Log("对象回收");
    }








}