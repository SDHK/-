using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SDHK_Extension;
using UnityEngine.UI;
using AssetBandleTool;
using TaskMachine;
using CanvasLayer;
using Singleton;


public class MouseCursor : SingletonMonoBase<MouseCursor>
{
    public GameObject mouseCursor;

    private Image cursor0;
    private Image cursor1;
    private Image cursor2;
    private float speed;

    private CanvasServer canvasServer = CanvasServer.Instance();

    public void Initialize()
    {
        mouseCursor = Instantiate(Cd.ABpfb_ui.ABLoadAsset<GameObject>(Cd.AB_MouseCursor), canvasServer.GetLayer(Cd.Layer6, Cd.CanvasName));
        if (mouseCursor != null)
        {
            speed = GameManager.value.cursorRotationSpeedMin;

            mouseCursor.transform.localScale = Vector3.one;
            mouseCursor.transform.eulerAngles = Vector3.zero;

            Cursor.visible = false;
            cursor0 = mouseCursor.SetComponent<Image>();
            cursor1 = mouseCursor.SetComponent<Image>("Cursor1");
            cursor2 = mouseCursor.SetComponent<Image>("Cursor2");
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (mouseCursor == null)
        {
            Initialize();
        }
        else
        {
            mouseCursor.transform.position = Screen_To_World(Input.mousePosition, GameManager.value.CanvasPlaneDistance);
            // mouseCursor.transform.position = Input.mousePosition;
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                cursor0.color = cursor0.color.A(GameManager.value.cursorAlphaMax);
                cursor1.color = cursor1.color.A(GameManager.value.cursorAlphaMax);
                cursor2.color = cursor2.color.A(GameManager.value.cursorAlphaMax);

                speed = GameManager.value.cursorRotationSpeedMax;

            }
            if (Input.GetKeyUp(KeyCode.Mouse0))
            {

                cursor0.color = cursor0.color.A(GameManager.value.cursorAlphaMin);
                cursor1.color = cursor1.color.A(GameManager.value.cursorAlphaMin);
                cursor2.color = cursor2.color.A(GameManager.value.cursorAlphaMin);

                speed = GameManager.value.cursorRotationSpeedMin;

            }

            cursor1.transform.Rotate(-Vector3.forward * Time.deltaTime * speed);
            cursor2.transform.Rotate(Vector3.forward * Time.deltaTime * speed);

        }

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
}
