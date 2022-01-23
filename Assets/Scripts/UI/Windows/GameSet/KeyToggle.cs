using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ObjectPool_;
using AssetBandleTool;
using LanguageSwitch;
using SDHK_Extension;

public class KeyToggle : MonoBehaviour, IMonoObjectPoolItem
{
    public MonoObjectPoolBase RecyclePool { get; set; }

    public static MonoObjectPool<KeyToggle> Pool = new MonoObjectPool<KeyToggle>
   (Cd.ABpfb_ui.ABLoadAsset<GameObject>(Cd.AB_KeyToggle))
    { clock = 600 }
   .RegisterManager();


    public Toggle toggle;
    public LanguageText keyToggleText;

    private Action<string> callBack;



    public void ObjectOnNew()
    {
        gameObject.SetComponent(ref toggle);
        toggle.gameObject.SetComponent(ref keyToggleText, "Text");
        toggle.onValueChanged.AddListener(Toggle);
    }

    public void Refresh(Action<string> callBack, string key)
    {
        this.callBack = callBack;
        keyToggleText.SetKey("按键绑定页面", key);
        keyToggleText.LanguageRefresh();
    }



    public void ObjectOnClear()
    {
    }

    public void ObjectOnGet()
    {
        transform.Default();
    }

    public void ObjectOnRecycle()
    {
        toggle.group = null;
        toggle.isOn = false;
    }

    public void Toggle(bool bit)
    {
        if (bit)
        {
            callBack(keyToggleText.key);
        }
    }
}
