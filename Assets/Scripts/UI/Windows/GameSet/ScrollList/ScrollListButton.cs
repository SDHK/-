using System;
using System.Collections;
using System.Collections.Generic;
using AssetBandleTool;
using LanguageSwitch;
using ObjectPool_;
using SDHK_Extension;
using UnityEngine;
using UnityEngine.UI;

public class ScrollListButton : MonoBehaviour, IMonoObjectPoolItem
{
    public MonoObjectPoolBase RecyclePool { get; set; }
    public static MonoObjectPool<ScrollListButton> pool = new MonoObjectPool<ScrollListButton>
    (Cd.ABpfb_ui.ABLoadAsset<GameObject>(Cd.AB_ScrollListButton))
    { clock = 600 }
    .RegisterManager()
    ;


    public LanguageText languageText;
    public Button button;
    public LanguageText btnText;
    public Action CallBack;

    public void ObjectOnNew()
    {
        gameObject.SetComponent(ref languageText, "LanguageText");

        gameObject.SetComponent(ref button, "Button");
        button.gameObject.SetComponent(ref btnText, "Text");
    }

    public void ObjectOnClear()
    {

    }

    public void ObjectOnGet()
    {
        transform.Default();

        button.onClick.AddListener(ButtonCallBack);
    }

    public void ObjectOnRecycle()
    {
        button.onClick.RemoveAllListeners();
    }

    public void Refresh(string group, string key, Action callback)
    {
        languageText.SetKey(group, key).LanguageRefresh();
        this.CallBack = callback;
    }

    private void ButtonCallBack()
    {
        CallBack?.Invoke();
    }
}
