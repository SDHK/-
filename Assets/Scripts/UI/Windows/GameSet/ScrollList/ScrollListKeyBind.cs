using System.Collections;
using System.Collections.Generic;
using AssetBandleTool;
using ObjectPool_;
using UnityEngine;
using UnityEngine.UI;
using LanguageSwitch;
using SDHK_Extension;
using InputKeys;
using WindowUI;
public class ScrollListKeyBind : MonoBehaviour, IMonoObjectPoolItem
{
    public MonoObjectPoolBase RecyclePool { get; set; }
    public static MonoObjectPool<ScrollListKeyBind> Pool = new MonoObjectPool<ScrollListKeyBind>
     (Cd.ABpfb_ui.ABLoadAsset<GameObject>(Cd.AB_ScrollListKeyBind))
    { clock = 600 }
     .RegisterManager();

    public LanguageText keyText;
    public Button keyBtn;
    public Text keyBtnText;

    public string group;
    public string key;

    private LanguageManager languageManager = LanguageManager.Instance();
    private InputKeysManager inputKeysManager = InputKeysManager.Instance();

    public void ObjectOnNew()
    {
        gameObject.SetComponent(ref keyText, "KeyText");
        gameObject.SetComponent(ref keyBtn, "KeyBtn");
        keyBtn.gameObject.SetComponent(ref keyBtnText, "Text");
        keyBtn.onClick.AddListener(KeyBtn);
    }
    public void ObjectOnClear()
    {

    }

    public void ObjectOnGet()
    {
    }
    public void ObjectOnRecycle()
    {
    }

    private void KeyBtn()
    {
        WindowMask.Show();

        inputKeysManager.RecordKeys(group, key);
        inputKeysManager.recordUpdateEvent += RefreshkeyBtnText;
        inputKeysManager.recordDoneEvent += ReplaceCallBack;

        keyBtnText.text = languageManager.GetValue("提示", "按键录制提示");
    }

    private void RefreshkeyBtnText(string group, string key, InputKeyCodes keyCodes)
    {
        keyBtnText.text = keyCodes.ToString();
    }

    private void ReplaceCallBack(string group, string key, InputKeyCodes keyCodes, InputKeyCodes newKeyCodes, List<string> repeatNames)
    {
        string logText;
        if (repeatNames.Count > 0)
        {
            logText = "[" + languageManager.GetValue(group, key) + "]\n\n" + keyCodes.ToString() + " --> " + newKeyCodes.ToString() + "\n";
            logText += languageManager.GetValue("提示", "同组按键冲突提示");
            foreach (var repeatName in repeatNames)
            {
                logText += "\n[" + languageManager.GetValue(group, repeatName) + "]";
            }
            WindowConfirm.pool.WindowShow().Refresh(logText, null);

            keyBtnText.text = keyCodes.ToString();
        }
        else if (newKeyCodes.Codes.Count > newKeyCodes.limit)
        {
            logText = "[" + languageManager.GetValue(group, key) + "]\n\n" + languageManager.GetValue("提示", "按键数超量提示") + keyCodes.Codes.Count;
            WindowConfirm.pool.WindowShow().Refresh(logText, null);
            keyBtnText.text = keyCodes.ToString();
        }
        else
        {
            logText = "[" + languageManager.GetValue(group, key) + "]\n\n " + languageManager.GetValue("提示", "按键替换确认") + "\n" + keyCodes.ToString() + "-->" + newKeyCodes.ToString();
            WindowConfirm.pool.WindowShow().Refresh(logText, (bit) =>
            {
                if (bit)
                {
                    group.InputSetKeyCodes(key, newKeyCodes);
                    keyBtnText.text = newKeyCodes.ToString();

                }
                else
                {
                    keyBtnText.text = keyCodes.ToString();
                }
            });
        }

        inputKeysManager.recordUpdateEvent -= RefreshkeyBtnText;
        inputKeysManager.recordDoneEvent -= ReplaceCallBack;

        WindowMask.Close();
    }

    public void Refresh(string group, string key)
    {
        this.group = group;
        this.key = key;
        keyText.SetKey(group, key);
        keyText.LanguageRefresh();
        keyBtnText.text = inputKeysManager.GetKeyCodes(group, key).ToString();
    }

}
