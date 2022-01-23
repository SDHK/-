using System;
using System.Collections;
using System.Collections.Generic;
using AssetBandleTool;
using LanguageSwitch;
using ObjectPool_;
using SDHK_Extension;
using UnityEngine;
using UnityEngine.UI;

public class ScrollListInputField : MonoBehaviour, IMonoObjectPoolItem
{

    public MonoObjectPoolBase RecyclePool { get; set; }
    public static MonoObjectPool<ScrollListInputField> pool = new MonoObjectPool<ScrollListInputField>
    (Cd.ABpfb_ui.ABLoadAsset<GameObject>(Cd.AB_ScrollListInputField))
    { clock = 600 }
    .RegisterManager()
    ;


    public LanguageText languageText;

    public InputField inputField;

    public Action<int> CallBack;

    private int value;

    private int min;
    private int max;


    public void ObjectOnNew()
    {
        gameObject.SetComponent(ref languageText, "LanguageText");
        gameObject.SetComponent(ref inputField, "InputField");
        // inputField.contentType = InputField.ContentType.IntegerNumber;//整数

    }
    public void ObjectOnClear()
    {
    }
    public void ObjectOnGet()
    {
        transform.Default();
        inputField.onEndEdit.AddListener(InputFieldCallBack);
    }

    public void ObjectOnRecycle()
    {
        inputField.onEndEdit.RemoveAllListeners();
    }

    public void Refresh(string group, string key, int value, int min, int max, Action<int> callback)
    {
        languageText.SetKey(group, key).LanguageRefresh();

        this.value = value;
        this.min = min;
        this.max = max;
        this.CallBack =callback;

        value = Mathf.Clamp(value, min, max);
        inputField.text = value.ToString();
    }

    private void InputFieldCallBack(string str)
    {
        value = Mathf.Clamp(int.Parse(str), min, max);
        inputField.text = value.ToString();

        CallBack?.Invoke(value);
    }


}
