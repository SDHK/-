using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using StateMachine;
using System;
using LanguageSwitch;
using UnityEngine.UI;
using SDHK_Extension;
using WindowUI;
using System.Linq;
using System.IO;

public class PageGameSet : MonoBehaviour, IFocusState
{
    public FocusStateMachine focusStateMachine { get; set; }
    public Transform content;

    public Button defaultSettingsBtn;
    public LanguageText defaultSettingsBtnText;
    public ScrollListDropdownString languageSwitchDropdownBox;


    private LanguageManager languageManager = LanguageManager.Instance();
    private ModelGameSet modelGameSet = ModelGameSet.Instance();


    private void Awake()
    {
        gameObject.SetComponent(ref content, "Content");

        gameObject.SetComponent(ref defaultSettingsBtn, "DefaultSettingsBtn");
        defaultSettingsBtn.gameObject.SetComponent(ref defaultSettingsBtnText, "Text").SetKey("游戏设置窗口", "恢复默认设置");
        defaultSettingsBtn.onClick.AddListener(DefaultSettings);

    }
    public void FocusStateEnter()
    {
        gameObject.SetActive(true);
        languageSwitchDropdownBox = ScrollListDropdownString.pool.Get(content);

        Refresh();
    }

    public void FocusStateExit()
    {
        gameObject.SetActive(false);

        languageSwitchDropdownBox.RecyclePool.Recycle(languageSwitchDropdownBox);
    }

    public void FocusStateUpdate()
    {
    }

    public void Refresh()
    {
        languageSwitchDropdownBox.Refresh("游戏设置页面", "语言", languageManager.GetLanguageNames()
        , modelGameSet.data.Language
        , LanguageDropdownCallBack);

    }

    private void LanguageDropdownCallBack(string str)
    {
        modelGameSet.data.Language = str;
        modelGameSet.LoadLanguage();
    }

    //默认设置
    private void DefaultSettings()
    {
        WindowConfirm.pool.WindowShow()
        .Refresh(languageManager.GetValue("提示", "恢复默认设置确认"), WindowConfirmCallback);
    }
    private void WindowConfirmCallback(bool bit)
    {
        if (bit)
        {
            modelGameSet.LoadDataDefault();
        }
    }

    private void OnDestroy()
    {
        defaultSettingsBtn.onClick.RemoveAllListeners();
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
