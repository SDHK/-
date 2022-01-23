using System;
using System.Collections;
using System.Collections.Generic;
using AssetBandleTool;
using LanguageSwitch;
using ObjectPool_;
using SDHK_Extension;
using UnityEngine;
using UnityEngine.UI;

public class ScrollListToggle : MonoBehaviour, IMonoObjectPoolItem
{

    public MonoObjectPoolBase RecyclePool { get; set; }
    public static MonoObjectPool<ScrollListToggle> pool = new MonoObjectPool<ScrollListToggle>
    (Cd.ABpfb_ui.ABLoadAsset<GameObject>(Cd.AB_ScrollListToggle))
    { clock = 600 }
    .RegisterManager()
    ;
    public LanguageText languageText;
    public Toggle toggle;
    public Action<bool> CallBack;


    public void ObjectOnNew()
    {
        gameObject.SetComponent(ref languageText, "LanguageText");
        gameObject.SetComponent(ref toggle, "Toggle");
    }

    public void ObjectOnClear()
    {
    }

    public void ObjectOnGet()
    {
        transform.Default();
        toggle.onValueChanged.AddListener(ToggleCallBack);
    }

    public void ObjectOnRecycle()
    {
        toggle.onValueChanged.RemoveAllListeners();
    }
    public void Refresh(string group, string key, bool bit, Action<bool> callback)
    {
        languageText.SetKey(group, key).LanguageRefresh();
        toggle.isOn = bit;
        this.CallBack = callback;
    }

    private void ToggleCallBack(bool bit)
    {
        CallBack?.Invoke(bit);
    }

}
