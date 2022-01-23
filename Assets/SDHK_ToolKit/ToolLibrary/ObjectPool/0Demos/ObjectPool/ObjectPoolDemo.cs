using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolDemo : MonoBehaviour
{
    public ObjectPoolTest test;

    void Update()
    {
        if (test == null && Input.GetKeyDown(KeyCode.A))
        {
            test = ObjectPoolTest.pool.Get();//直接从对象池获取一个对象
        }

        if (Input.GetKeyDown(KeyCode.D))//回收对象
        {
            ObjectPoolTest.pool.Recycle(test);
            test = null;
        }

    }
}
