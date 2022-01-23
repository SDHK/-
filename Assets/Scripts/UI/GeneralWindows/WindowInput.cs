using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using WindowUI;
using SDHK_Extension;
using InputKeys;
using LanguageSwitch;
using UnityEngine.EventSystems;
using TaskMachine;
using EventDelegate_;
using ObjectPool_;
using AssetBandleTool;
using CanvasLayer;
using DG.Tweening;

public class WindowInput : WindowBase
{
    public static MonoObjectPool<WindowInput> pool = new MonoObjectPool<WindowInput>(Cd.ABpfb_ui.ABLoadAsset<GameObject>(Cd.AB_WindowInput))
    { clock = 600 }
    .RegisterManager();


    public Text inputTitle;
    public InputField inputField;

    public Button confirmBtn;
    public Button cancelBtn;

    public Text cancelBtnText;
    public Text confirmBtnText;

    private Action<string> callBack;

    private List<string> IllegalChar = new List<string>();

    private CanvasServer canvasServer = CanvasServer.Instance();

    private LanguageManager languageManager = LanguageManager.Instance();
    private InputKeysManager inputKeysManager = InputKeysManager.Instance();

    public override void ObjectOnNew()
    {
        CanvasGroup.alpha = 0;
        CanvasGroup.interactable = false;

        gameObject.SetComponent(ref inputTitle, "InputTitle");
        gameObject.SetComponent(ref inputField, "InputField");

        gameObject.SetComponent(ref confirmBtn, "ConfirmBtn");
        gameObject.SetComponent(ref cancelBtn, "CancelBtn");

        gameObject.SetComponent(ref confirmBtnText, "ConfirmBtnText");
        gameObject.SetComponent(ref cancelBtnText, "CancelBtnText");

        confirmBtn.onClick.AddListener(ConfirmBtn);
        cancelBtn.onClick.AddListener(this.WindowClose);
    }

    public override void ObjectOnClear()
    {
        confirmBtn.onClick.RemoveListener(ConfirmBtn);
        cancelBtn.onClick.RemoveListener(this.WindowClose);
    }

    public override void ObjectOnGet()
    {
        transform.SetParent(canvasServer.GetLayer(Cd.Layer3));

        confirmBtnText.text = languageManager.GetValue("界面快捷键", "确认") + inputKeysManager.GetKeyCodes("界面快捷键", "确认")?.ToString();
        cancelBtnText.text = languageManager.GetValue("界面快捷键", "取消") + inputKeysManager.GetKeyCodes("界面快捷键", "取消")?.ToString();

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

    public override void FocusStateEnter()
    {
        EventSystem.current.SetSelectedGameObject(confirmBtn.gameObject);//设置初始选中物体
    }

    public override void FocusStateUpdate()
    {
        foreach (var item in IllegalChar)
        {
            inputField.text = inputField.text.Replace(item, "");
        }

        if (!inputField.isFocused && "界面快捷键".InputGetKeysDown("确认"))
        {
            ConfirmBtn();
        }

        if (!inputField.isFocused && "界面快捷键".InputGetKeysDown("取消"))
        {
            this.WindowClose();
        }
    }


    private void ConfirmBtn()
    {
        this.WindowClose();
        if (callBack != null) callBack(inputField.text);
    }

    /// <summary>
    /// 显示刷新
    /// </summary>
    /// <param name="titleStr">显示输入提示文字</param>
    /// <param name="inputStr">自动生成的字符串</param>
    /// <param name="callBack">结果回调</param>
    /// <param name="illegalChar">限制字符集</param>
    public void Refresh(string titleStr, string inputStr, Action<string> callBack, List<string> illegalChar = null)
    {
        inputTitle.text = titleStr;
        this.callBack = callBack;
        inputField.text = inputStr;
        if (illegalChar != null) IllegalChar = illegalChar;
    }
}
