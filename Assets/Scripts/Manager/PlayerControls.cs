using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SDHK_Extension;
using InputKeys;

public class PlayerControls : MonoBehaviour
{

    public Transform core;
    private Rigidbody2D rbody2d;
    private Vector2 direction = Vector2.zero;
    public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetComponent(ref rbody2d);


        // gameObject.SetComponent<Renderer>("Weapon").material.SetFloat("Intensity", 2f);
        // 通过renderer进行材质的单独修改

        // gameObject.SetComponent<SpriteRenderer>("Weapon").sharedMaterial.SetFloat("Intensity", 2f);
        //通过renderer进行共享材质的修改

    }

    private void Update()//Fixed
    {
        direction = Vector2.zero;


        if ("游戏控制".InputGetKeys("前进"))
        {
            direction += Vector2.up;
        }

        if ("游戏控制".InputGetKeys("后退"))
        {
            direction += Vector2.down;
        }

        if ("游戏控制".InputGetKeys("左移"))
        {
            direction += Vector2.left;
        }

        if ("游戏控制".InputGetKeys("右移"))
        {
            direction += Vector2.right;
        }

        rbody2d.MovePosition(rbody2d.position + direction.normalized * speed);

        // core.eulerAngles = new Vector3(0, 0, -Get_Angle_In_Vector2(Screen_To_World(Input.mousePosition, 10) - transform.position));
        core.eulerAngles = new Vector3(0, 0, -Get_Angle_In_Vector2(MouseCursor.Instance().mouseCursor.transform.position - transform.position));

    }


    /// <summary>
    /// 屏幕像素坐标转世界坐标:Z为物体与相机的水平距离
    /// </summary>
    /// <param name="ScreenPoint">屏幕像素坐标</param>
    /// <param name="PlaneDistance">画布距离</param>
    /// <returns>世界坐标</returns>
    public static Vector3 Screen_To_World(Vector2 ScreenPoint, float PlaneDistance)
    {
        return Camera.main.ScreenToWorldPoint(new Vector3(ScreenPoint.x, ScreenPoint.y, PlaneDistance));
    }

    /// <summary>
    /// 二维向量转换为角度：向量不能为0
    /// </summary>
    /// <param name="vector2">要转换的向量</param>
    /// <returns>return ： 角度(360度)</returns>
    public static float Get_Angle_In_Vector2(Vector2 vector2)
    {
        return Quaternion.LookRotation(new Vector3(vector2.x, 0, vector2.y)).eulerAngles.y;  //返回最终角度
    }



}
