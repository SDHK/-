using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MonoObjectPoolDemo : MonoBehaviour
{

    public MonoObjectPoolTest CubeTest;
    public MonoObjectPoolTest SphereTest;
    private void Start()
    {
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            CubeTest = MonoObjectPoolTest.CubePool.Get(transform);//直接从对象池获取一个对象
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            SphereTest = MonoObjectPoolTest.SpherePool.Get(transform);//直接从对象池获取一个对象
        }



        if (Input.GetKeyDown(KeyCode.A))//回收
        {
            CubeTest.Recycle();
        }
        if (Input.GetKeyDown(KeyCode.D))//回收
        {
            SphereTest.RecyclePool.Recycle(SphereTest);//假如没写可以这么回收。
        }
    }
}



