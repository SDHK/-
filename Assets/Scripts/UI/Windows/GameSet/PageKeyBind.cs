using System;
using System.Collections;
using System.Collections.Generic;
using StateMachine;
using UnityEngine;
using UnityEngine.UI;
using InputKeys;
using SDHK_Extension;
using LanguageSwitch;
using WindowUI;

public class PageKeyBind : MonoBehaviour, IFocusState
{
    public FocusStateMachine focusStateMachine { get; set; }


    public Button defaultSettingsBtn;
    public LanguageText defaultSettingsBtnText;


    public ToggleGroup keyToggleGroup;
    public Transform content;


    private List<KeyToggle> keyToggles = new List<KeyToggle>();
    private List<ScrollListKeyBind> keyBindBoxes = new List<ScrollListKeyBind>();

    private LanguageManager languageManager = LanguageManager.Instance();
    private ModelGameSet modelGameSet = ModelGameSet.Instance();

    private void Awake()
    {
        gameObject.SetComponent(ref keyToggleGroup, "KeyToggleGroup");
        gameObject.SetComponent(ref content, "Content");

        gameObject.SetComponent(ref defaultSettingsBtn, "DefaultSettingsBtn");

        defaultSettingsBtn.gameObject.SetComponent(ref defaultSettingsBtnText, "Text").SetKey("游戏设置窗口", "恢复默认设置");
        defaultSettingsBtn.onClick.AddListener(DefaultSettings);



        modelGameSet.inputKeyRefresh += Refresh;
    }

    private void OnDestroy()
    {
        modelGameSet.inputKeyRefresh -= Refresh;
        defaultSettingsBtn.onClick.RemoveAllListeners();
    }
    

    public void FocusStateEnter()
    {
        gameObject.SetActive(true);
        Refresh();
    }

    public void FocusStateExit()
    {
        gameObject.SetActive(false);
        Recycle();
    }

    public void FocusStateUpdate()
    {
    }

    private void Refresh()
    {
        Recycle();
        foreach (var inputKeyGroup in InputKeysManager.Instance().inputKeyGroups)
        {
            KeyToggle keyToggle = KeyToggle.Pool.Get(keyToggleGroup.transform);
            keyToggle.toggle.group = keyToggleGroup;
            keyToggle.Refresh(RefreshContent, inputKeyGroup.Key);
            keyToggles.Add(keyToggle);
        }

        if (keyToggles.Count > 0)
        {
            keyToggles[0].toggle.isOn = true;
        }
    }


    private void RefreshContent(string group)
    {
        foreach (var keyBindBoxe in keyBindBoxes)
        {
            keyBindBoxe.RecyclePool.Recycle(keyBindBoxe);
        }
        keyBindBoxes.Clear();

        foreach (var inputKey in InputKeysManager.Instance().inputKeyGroups[group])
        {
            ScrollListKeyBind keyBindBox = ScrollListKeyBind.Pool.Get();
            keyBindBox.Refresh(group, inputKey.Key);
            keyBindBoxes.Add(keyBindBox);
            keyBindBox.transform.SetParent(content);
            keyBindBox.transform.Default();
        }
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
            modelGameSet.LoadInputKeysDefault();
        }
    }


    private void Recycle()
    {
        foreach (var keyToggle in keyToggles)
        {
            keyToggle.RecyclePool.Recycle(keyToggle);
        }
        foreach (var keyBindBoxe in keyBindBoxes)
        {
            keyBindBoxe.RecyclePool.Recycle(keyBindBoxe);
        }
        keyToggles.Clear();
        keyBindBoxes.Clear();

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