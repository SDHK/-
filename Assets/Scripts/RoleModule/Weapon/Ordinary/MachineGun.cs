using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MachineGun : WeaponBase
{

    GameObject bullet;

    public override void On()
    {

        // bullet = GameObjectManager.GetPool(bullet_Pfb).Get();

        // bullet = bullet_Pfb.GetObject();//通过预制体.实例化一个对象


        bullet.transform.position = transform.position + transform.up * 1;


    }

    public override void Off()
    {
        // bullet_Pfb.SetObject(bullet);
        // bullet.SetObject();//回收对象
    }


}
