using System;
using System.Collections;
using System.Collections.Generic;
using LanguageSwitch;
using SDHK_Extension;
using StateMachine;
using UnityEngine;
using UnityEngine.UI;
using ScreenResolution;
using WindowUI;
using UnityEngine.Networking;

public class PageScreen : MonoBehaviour, IFocusState
{
    public FocusStateMachine focusStateMachine { get; set; }

    public Transform content;

    public ScrollListDropdownEnum screenMode;
    public ScrollListToggle screenTop;
    public ScrollListInputField screenWidth;
    public ScrollListInputField screenHeight;

    public ScrollListButton screenAutoFit;
    public ScrollListButton screenSaveConfirm;


    public Button defaultSettingsBtn;
    public LanguageText defaultSettingsBtnText;


    private ScreenManager screenManager = ScreenManager.Instance();
    private LanguageManager languageManager = LanguageManager.Instance();
    private ModelGameSet modelGameSet = ModelGameSet.Instance();


    private void Awake()
    {
        gameObject.SetComponent(ref content, "Content");
        gameObject.SetComponent(ref defaultSettingsBtn, "DefaultSettingsBtn");

        defaultSettingsBtn.onClick.AddListener(DefaultSettings);
        defaultSettingsBtn.gameObject.SetComponent(ref defaultSettingsBtnText, "Text").SetKey("游戏设置窗口", "恢复默认设置");



    }

    public void FocusStateEnter()
    {
        gameObject.SetActive(true);

        screenMode = ScrollListDropdownEnum.pool.Get(content);
        screenTop = ScrollListToggle.pool.Get(content);
        screenWidth = ScrollListInputField.pool.Get(content);
        screenHeight = ScrollListInputField.pool.Get(content);
        screenAutoFit = ScrollListButton.pool.Get(content);
        screenSaveConfirm = ScrollListButton.pool.Get(content);

        Refresh();
    }
    public void FocusStateExit()
    {
        gameObject.SetActive(false);

        screenMode.RecyclePool.Recycle(screenMode);
        screenTop.RecyclePool.Recycle(screenTop);
        screenWidth.RecyclePool.Recycle(screenWidth);
        screenHeight.RecyclePool.Recycle(screenHeight);
        screenAutoFit.RecyclePool.Recycle(screenAutoFit);
        screenSaveConfirm.RecyclePool.Recycle(screenSaveConfirm);
    }

    public void Refresh()
    {
        screenMode.Refresh("显示设置页面", "屏幕模式", screenManager.data.mode, ScreenModeCallBack);
        screenTop.Refresh("显示设置页面", "屏幕顶置", screenManager.data.isTop, ScreenTopCallBack);
        screenWidth.Refresh("显示设置页面", "屏幕宽度", screenManager.data.width, 100, 10000, ScreenWidthCallBack);
        screenHeight.Refresh("显示设置页面", "屏幕高度", screenManager.data.height, 100, 10000, ScreenHeightCallBack);
        screenAutoFit.Refresh("显示设置页面", "比例计算", AutoFitBtn);
        screenSaveConfirm.Refresh("显示设置页面", "保存屏幕设置", ConfirmBtn);
    }


    private void ScreenModeCallBack(object mode)
    {
        screenManager.data.mode = (ScreenMode)mode;
    }
    private void ScreenTopCallBack(bool bit)
    {
        screenManager.data.isTop = bit;
    }
    private void ScreenWidthCallBack(int width)
    {
        screenManager.data.width = width;
    }
    private void ScreenHeightCallBack(int height)
    {
        screenManager.data.height = height;
    }

    private void AutoFitBtn()
    {
        screenManager.ScreenAutoFit();
        screenWidth.inputField.text = screenManager.data.width.ToString();
        screenHeight.inputField.text = screenManager.data.height.ToString();
    }
    private void ConfirmBtn()
    {
        screenManager.Refresh();

        WindowClock.pool.WindowShow()
        .Refresh(languageManager.GetValue("提示", "保存设置确认"), 10,
            (bit) =>
            {
                if (bit)
                {
                    modelGameSet.SaveScreen();
                    Refresh();
                }
                else
                {
                    screenManager.RestoreData();
                    Refresh();
                }
            }
        );
    }
    private void DefaultSettings()
    {
        WindowConfirm.pool.WindowShow()
        .Refresh(languageManager.GetValue("提示", "恢复默认设置确认"), WindowConfirmCallback);
    }
    private void WindowConfirmCallback(bool bit)
    {
        if (bit)
        {
            modelGameSet.LoadScreenDefault();
        }
    }

    private void OnDestroy()
    {


        defaultSettingsBtn.onClick.RemoveAllListeners();
    }

    public void FocusStateUpdate()
    {
    }

    public void WaitFocusStateEnter(Action EnterDone)
    {
        EnterDone();
    }

    public void WaitFocusStateExit(Action ExitDone)
    {
        ExitDone();
    }


}
