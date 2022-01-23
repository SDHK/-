using System.Collections;
using System.Collections.Generic;
using SDHK_Extension;
using UnityEngine;
using UnityEngine.UI;
using LanguageSwitch;
using WindowUI;
using ObjectPool_;
using AssetBandleTool;
using CanvasLayer;
using DG.Tweening;
using System;

public class WindowLoad : WindowBase
{
    public static MonoObjectPool<WindowLoad> pool = new MonoObjectPool<WindowLoad>(Cd.ABpfb_ui.ABLoadAsset<GameObject>(Cd.AB_WindowLoad))
    { clock = 600 }
    .RegisterManager();


    public LanguageText text;
    private Image loadImage;
    private Image loadImage1;
    private Image loadImage2;

    private CanvasServer canvasServer = CanvasServer.Instance();


    public override void ObjectOnNew()
    {
        CanvasGroup.alpha = 0;
        CanvasGroup.interactable = false;

        gameObject.SetComponent(ref text, "Text");
        gameObject.SetComponent(ref loadImage, "LoadImage");
        gameObject.SetComponent(ref loadImage1, "LoadImage1");
        gameObject.SetComponent(ref loadImage2, "LoadImage2");

        text.SetKey("提示", "加载中");
    }

    public override void ObjectOnGet()
    {
        transform.SetParent(canvasServer.GetLayer(Cd.Layer4));
    }

    public override void ObjectOnRecycle()
    {
    }

    public override void ObjectOnClear()
    {
    }
    public override void WaitStackStateEnter(Action EnterDone)
    {
        transform.Default();
        RectAllStretch();

        CanvasGroup.DOFade(1, Cd.WindowFadeSpeed).OnComplete(() => EnterDone());
    }
    public override void WaitStackStateExit(Action ExitDone)
    {
        CanvasGroup.DOFade(0, Cd.WindowFadeSpeed).OnComplete(() => ExitDone());
    }
    private void Update()
    {
        loadImage1?.transform.Rotate(-Vector3.forward * Time.deltaTime * GameManager.value.cursorRotationSpeedMin);
        loadImage2?.transform.Rotate(Vector3.forward * Time.deltaTime * GameManager.value.cursorRotationSpeedMin);
    }


}
