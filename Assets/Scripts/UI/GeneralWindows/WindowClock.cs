using System;
using System.Collections;
using System.Collections.Generic;
using AssetBandleTool;
using CanvasLayer;
using DG.Tweening;
using InputKeys;
using LanguageSwitch;
using ObjectPool_;
using SDHK_Extension;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using WindowUI;

public class WindowClock : WindowBase
{

    public static MonoObjectPool<WindowClock> pool = new MonoObjectPool<WindowClock>(Cd.ABpfb_ui.ABLoadAsset<GameObject>(Cd.AB_WindowConfirm))
    { clock = 600 }
    .RegisterManager();


    public Text text;

    public Button confirmBtn;
    public Button cancelBtn;

    public Text cancelBtnText;
    public Text confirmBtnText;

    private Action<bool> callBack;


    private string textStr = "";
    private float winClock = -1;


    private CanvasServer canvasServer = CanvasServer.Instance();

    private LanguageManager languageManager = LanguageManager.Instance();
    private InputKeysManager inputKeysManager = InputKeysManager.Instance();

    public override void ObjectOnNew()
    {
        CanvasGroup.alpha = 0;
        CanvasGroup.interactable = false;

        gameObject.SetComponent(ref text, "Text");

        gameObject.SetComponent(ref confirmBtn, "ConfirmBtn");
        gameObject.SetComponent(ref cancelBtn, "CancelBtn");

        gameObject.SetComponent(ref confirmBtnText, "ConfirmBtnText");
        gameObject.SetComponent(ref cancelBtnText, "CancelBtnText");


        confirmBtn.onClick.AddListener(ConfirmBtn);
        cancelBtn.onClick.AddListener(CancelBtn);
    }
    public override void ObjectOnClear()
    {
        confirmBtn.onClick.RemoveListener(ConfirmBtn);
        cancelBtn.onClick.RemoveListener(CancelBtn);
    }

    public override void ObjectOnGet()
    {
        transform.SetParent(canvasServer.GetLayer(Cd.Layer3));

    }

    public override void ObjectOnRecycle()
    {
    }

    public override void WaitStackStateEnter(Action EnterDone)
    {
        transform.Default();
        RectAllStretch();

        confirmBtnText.text = languageManager.GetValue("界面快捷键", "确认") + inputKeysManager.GetKeyCodes("界面快捷键", "确认")?.ToString();
        cancelBtnText.text = languageManager.GetValue("界面快捷键", "取消") + inputKeysManager.GetKeyCodes("界面快捷键", "取消")?.ToString();

        CanvasGroup.DOFade(1, Cd.WindowFadeSpeed).OnComplete(() => EnterDone());
    }
    public override void WaitStackStateExit(Action ExitDone)
    {
        CanvasGroup.DOFade(0, Cd.WindowFadeSpeed).OnComplete(() => ExitDone());
    }

    public override void StackStateUpdate()
    {
        if (winClock != -1)
        {
            if (winClock > 0)
            {
                winClock -= Time.deltaTime;
                text.text = textStr + "\n\n" + winClock.ToString("0.0");
            }
            else
            {
                winClock = -1;
                CancelBtn();
            }
        }
    }

    public override void FocusStateEnter()
    {
        EventSystem.current.SetSelectedGameObject(cancelBtn.gameObject);//设置初始选中物体
    }
    public override void FocusStateUpdate()
    {
        if ("界面快捷键".InputGetKeysDown("确认"))
        {
            ConfirmBtn();
        }

        if ("界面快捷键".InputGetKeysDown("取消"))
        {
            CancelBtn();
        }
    }

    /// <summary>
    /// 显示刷新
    /// </summary>
    /// <param name="textStr">显示文本</param>
    /// <param name="clock">倒计时</param>
    /// <param name="callBack">确认回调</param>
    public void Refresh(string textStr, float clock, Action<bool> callBack)
    {
        this.textStr = textStr;
        this.winClock = clock;
        this.callBack = callBack;
    }

    private void ConfirmBtn()
    {
        winClock = -1;
        this.WindowClose();
        if (callBack != null) callBack(true);
    }

    private void CancelBtn()
    {
        winClock = -1;
        this.WindowClose();
        if (callBack != null) callBack(false);
    }

}
