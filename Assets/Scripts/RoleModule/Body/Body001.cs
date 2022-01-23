using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body001 : BodyBase
{



    void Start()
    {


    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("碰撞");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("触发");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
