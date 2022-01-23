using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TaskMachine;


public class Bullet001 : BulletBase
{
    public int Damage;
    public float timeClock;


    private void OnEnable()
    {
        timeClock = 5;//倒计时
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        Recycle();
    }

    private void FixedUpdate()
    {
        transform.position += transform.up * 0.01f;

        timeClock -= Time.fixedDeltaTime;
        if (timeClock <= 0)
        {
            Recycle();
        }
    }

    public void Recycle()
    {
        timeClock = 0;
        // gameObject.SetObject();
    }
}
