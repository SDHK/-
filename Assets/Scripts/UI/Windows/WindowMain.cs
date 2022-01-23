using System.Collections;
using System.Collections.Generic;
using AssetBandleTool;
using UnityEngine;
using UnityEngine.UI;
using LanguageSwitch;
using TaskMachine;
using SDHK_Extension;
using UnityEngine.EventSystems;
using WindowUI;
using ObjectPool_;
using CanvasLayer;
using System;
using DG.Tweening;
using InputKeys;

public class WindowMain : WindowBase //窗口：主界面
{
    public static MonoObjectPool<WindowMain> pool = new MonoObjectPool<WindowMain>(Cd.ABpfb_ui.ABLoadAsset<GameObject>(Cd.AB_WindowMain))
    { clock = 600, maxCount = 1 }
    .RegisterManager();

    public LanguageText gameName;

    public Button startBtn;
    public Button setBtn;

    private CanvasServer canvasServer = CanvasServer.Instance();

    public LanguageText startBtnText;
    public LanguageText setBtnText;

    public override void ObjectOnNew()
    {
        CanvasGroup.alpha = 0;
        CanvasGroup.interactable = false;

        gameObject.SetComponent(ref startBtn, "StartBtn");
        gameObject.SetComponent(ref setBtn, "SetBtn");

        gameObject.SetComponent(ref gameName, "GameName")?.SetKey("主界面", "游戏名字");
        gameObject.SetComponent(ref startBtnText, "StartBtnText")?.SetKey("主界面", "开始");
        gameObject.SetComponent(ref setBtnText, "SetBtnText")?.SetKey("主界面", "设置");

        startBtn?.onClick.AddListener(ShowArchive);//打开存档界面
        setBtn?.onClick.AddListener(ShowGameSet);//打开设置界面
    }
    public override void ObjectOnClear()
    {
        startBtn?.onClick.RemoveListener(ShowArchive);
        setBtn?.onClick.RemoveListener(ShowGameSet);
    }

    public override void ObjectOnGet()
    {
        transform.SetParent(canvasServer.GetLayer(Cd.Layer1));
    }
    public override void ObjectOnRecycle()
    {
    }

    public override void WaitFocusStateEnter(Action EnterDone)
    {
        CanvasGroup.DOFade(1, Cd.WindowFadeSpeed).OnComplete(() => base.WaitFocusStateEnter(EnterDone));
    }
    public override void WaitFocusStateExit(Action ExitDone)
    {
        CanvasGroup.interactable = false;
        CanvasGroup.DOFade(0, Cd.WindowFadeSpeed).OnComplete(() => ExitDone());
    }



    public override void FocusStateEnter()
    {
        EventSystem.current.SetSelectedGameObject(startBtn.gameObject);//设置初始选中物体
    }

    public override void FocusStateExit()
    {

    }

    public override void FocusStateUpdate()
    {
        if ("界面快捷键".InputGetKeysDown("返回"))
        {
            WindowConfirm.pool.WindowShow()
            .Refresh(LanguageManager.Instance().GetValue("提示", "退出游戏确认"), QuitGame)
            ;
        }
    }

    public void QuitGame(bool bit)
    {
        if (bit)
        {
            Application.Quit();
        }
    }


    private void ShowArchive()
    {
        WindowArchive.pool.WindowShow();
    }

    private void ShowGameSet()
    {
        WindowGameSet.pool.WindowShow();
    }
}
