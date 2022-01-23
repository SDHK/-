using System.Collections;
using System.Collections.Generic;
using AssetBandleTool;
using ObjectPool_;
using SDHK_Extension;
using UnityEngine;
using UnityEngine.UI;
using WindowUI;
using StateMachine;
using LanguageSwitch;
using CanvasLayer;
using UnityEngine.EventSystems;
using InputKeys;
using System;
using DG.Tweening;

public class WindowGameSet : WindowBase
{
    public static MonoObjectPool<WindowGameSet> pool = new MonoObjectPool<WindowGameSet>(Cd.ABpfb_ui.ABLoadAsset<GameObject>(Cd.AB_WindowGameSet))
    { clock = 600, maxCount = 1 }
   .RegisterManager();


    public Button returnBtn;
    public LanguageText returnBtnText;
    public LanguageText newBtnText;

    public ToggleGroup toggleGroup;

    public Toggle gameSetToggle;
    public Toggle keyBindToggle;
    public Toggle ScreenToggle;

    public LanguageText gameSetToggleText;
    public LanguageText keyBindToggleText;
    public LanguageText ScreenToggleText;


    public PageGameSet pageGameSet;
    public PageKeyBind pageKeyBind;
    public PageScreen pageScreen;

    private CanvasServer canvasServer = CanvasServer.Instance();
    private ModelGameSet modelGameSet = ModelGameSet.Instance();

    public override void ObjectOnNew()
    {
        CanvasGroup.alpha = 0;
        CanvasGroup.interactable = false;

        gameObject.SetComponent(ref returnBtn, "ReturnBtn");

        returnBtn?.onClick.AddListener(this.WindowClose);

        gameObject.SetComponent(ref toggleGroup, "ToggleGroup");
        gameObject.SetComponent(ref gameSetToggle, "GameSetToggle");
        gameObject.SetComponent(ref keyBindToggle, "KeyBindToggle");
        gameObject.SetComponent(ref ScreenToggle, "ScreenToggle");

        gameObject.SetComponent(ref pageGameSet, "PageGameSet");
        gameObject.SetComponent(ref pageKeyBind, "PageKeyBind");
        gameObject.SetComponent(ref pageScreen, "PageScreen");

        gameSetToggle.gameObject.SetComponent(ref gameSetToggleText, "Text").SetKey("游戏设置窗口", "游戏设置");
        keyBindToggle.gameObject.SetComponent(ref keyBindToggleText, "Text").SetKey("游戏设置窗口", "按键绑定");
        ScreenToggle.gameObject.SetComponent(ref ScreenToggleText, "Text").SetKey("游戏设置窗口", "显示设置");


        gameSetToggle.onValueChanged.AddListener(ShowGameSet);
        keyBindToggle.onValueChanged.AddListener(ShowkeyBind);
        ScreenToggle.onValueChanged.AddListener(ShowScreen);


    }

    public override void ObjectOnClear()
    {
        gameSetToggle.onValueChanged.RemoveListener(ShowGameSet);
        keyBindToggle.onValueChanged.RemoveListener(ShowkeyBind);
        ScreenToggle.onValueChanged.RemoveListener(ShowScreen);
    }


    public void ShowGameSet(bool bit)
    {
        if (bit) this.FocusStateMachineGet().Set(pageGameSet);
    }

    public void ShowkeyBind(bool bit)
    {
        if (bit) this.FocusStateMachineGet().Set(pageKeyBind);
    }

    public void ShowScreen(bool bit)
    {
        if (bit) this.FocusStateMachineGet().Set(pageScreen);
    }

    public override void ObjectOnGet()
    {
        transform.SetParent(canvasServer.GetLayer(Cd.Layer1));
    }

    public override void ObjectOnRecycle()
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

    public override void StackStateEnter()
    {
        EventSystem.current.SetSelectedGameObject(gameSetToggle.gameObject);//设置初始选中物体
        gameSetToggle.isOn = true;
    }

    public override void FocusStateEnter()
    {
        EventSystem.current.SetSelectedGameObject(gameSetToggle.gameObject);//设置初始选中物体
    }

    public override void FocusStateExit()
    {
        modelGameSet.SaveData();
        modelGameSet.SaveInputKeys();
    }

    public override void FocusStateUpdate()
    {
        if ("界面快捷键".InputGetKeysDown("返回"))
        {
            this.WindowClose();
        }
    }




}
