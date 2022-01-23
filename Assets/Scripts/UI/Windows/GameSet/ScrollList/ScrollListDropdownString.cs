using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ObjectPool_;
using LanguageSwitch;
using UnityEngine.UI;
using SDHK_Extension;
using System;
using System.Linq;
using AssetBandleTool;

public class ScrollListDropdownString : MonoBehaviour, IMonoObjectPoolItem
{

    public MonoObjectPoolBase RecyclePool { get; set; }
    public static MonoObjectPool<ScrollListDropdownString> pool = new MonoObjectPool<ScrollListDropdownString>
    (Cd.ABpfb_ui.ABLoadAsset<GameObject>(Cd.AB_ScrollListDropdown))
    { clock = 600 }
    .RegisterManager()
    ;

    public LanguageText languageText;
    public Dropdown dropdown;
    public Action<string> CallBack;

    public List<string> strs;


    public void ObjectOnNew()
    {
        gameObject.SetComponent(ref languageText, "LanguageText");
        gameObject.SetComponent(ref dropdown, "Dropdown");
    }
    public void ObjectOnClear()
    {
    }
    public void ObjectOnGet()
    {
        transform.Default();
        dropdown.onValueChanged.AddListener(DropdownCallBack);
    }

    public void ObjectOnRecycle()
    {
        dropdown.onValueChanged.RemoveAllListeners();
    }
    public void Refresh(string group, string key, List<string> strs, string str, Action<string> callback)
    {
        languageText.SetKey(group, key).LanguageRefresh();

        dropdown.ClearOptions();
        dropdown.AddOptions(strs);

        this.strs = strs;
        dropdown.value = strs.FindIndex((name_) => name_ == str);
        this.CallBack = callback;
    }
    private void DropdownCallBack(int index)
    {
        if (CallBack != null) CallBack(strs[index]);
    }
}
