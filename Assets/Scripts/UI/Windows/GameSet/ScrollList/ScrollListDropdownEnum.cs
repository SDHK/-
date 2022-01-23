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

public class ScrollListDropdownEnum : MonoBehaviour, IMonoObjectPoolItem
{
    public MonoObjectPoolBase RecyclePool { get; set; }
    public static MonoObjectPool<ScrollListDropdownEnum> pool = new MonoObjectPool<ScrollListDropdownEnum>
    (Cd.ABpfb_ui.ABLoadAsset<GameObject>(Cd.AB_ScrollListDropdown))
    { clock = 600 }
    .RegisterManager()
    ;

    public LanguageText languageText;
    public Dropdown dropdown;

    public Action<object> CallBack;
    private Array enumArray;
    private LanguageManager languageManager = LanguageManager.Instance();


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

    public void Refresh(string group, string key, Enum enum_, Action<object> callback)
    {
        languageText.SetKey(group, key).LanguageRefresh();

        enumArray = Enum.GetValues(enum_.GetType());

        List<string> enums = Enum.GetNames(enum_.GetType()).Select((enumKey) => languageManager.GetValue(group, enumKey)).ToList();

        dropdown.ClearOptions();
        dropdown.AddOptions(enums);
        dropdown.value = enums.FindIndex((name_) => name_ == languageManager.GetValue(group, enum_.ToString()));
        this.CallBack = callback;
    }

    private void DropdownCallBack(int index)
    {
        if (CallBack != null) CallBack(enumArray.GetValue(index));
    }


}
