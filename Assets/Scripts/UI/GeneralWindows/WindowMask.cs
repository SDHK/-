using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WindowUI;
using Singleton;
using AssetBandleTool;
using ObjectPool_;
using CanvasLayer;
using SDHK_Extension;

/// <summary>
/// UI点击屏蔽层
/// </summary>
public class WindowMask : MonoBehaviour
{
    private static WindowMask windowMask;
    private static MonoObjectPool<WindowMask> pool = new MonoObjectPool<WindowMask>(Cd.ABpfb_ui.ABLoadAsset<GameObject>(Cd.AB_WindowMask))
    { clock = 600 }
    .RegisterManager();

    private CanvasServer canvasServer = CanvasServer.Instance();

    public static void Show()
    {
        if (windowMask != null)
        {
            windowMask.gameObject.SetActive(true);
        }
        else
        {
            windowMask = pool.Get();
            windowMask.transform.SetParent(windowMask.canvasServer.GetLayer(Cd.Layer5));
            windowMask.transform.Default().GetRectTransform().RectAllStretch();
        }
    }

    public static void Close()
    {
        windowMask.gameObject.SetActive(false);
    }

}
