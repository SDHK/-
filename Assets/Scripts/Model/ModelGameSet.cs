using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using CoroutineSystem;
using InputKeys;
using LanguageSwitch;
using LitJson;
using Singleton;
using UnityEngine;
using UnityEngine.Networking;
using WindowUI;
using SDHK_Extension;
using ScreenResolution;
using AsyncAwaitEvent;
using System.Threading.Tasks;

/// <summary>
/// 游戏全局设置的数据管理
/// </summary>

public class ModelGameSet : SingletonBase<ModelGameSet>
{

    public DataGameSet data;


    private LanguageManager languageManager = LanguageManager.Instance();
    private InputKeysManager inputKeysManager = InputKeysManager.Instance();
    private ScreenManager screenManager = ScreenManager.Instance();

    public event Action inputKeyRefresh;
    public event Action languageRefresh;
    public event Action screenRefresh;
    public event Action loadDoneEvent;

    public override void OnInstance()
    {
        languageManager.RootPath = ApplicationPathEnum.StreamingAssetsPath;
        inputKeysManager.RootPath = ApplicationPathEnum.StreamingAssetsPath;
        screenManager.RootPath = ApplicationPathEnum.StreamingAssetsPath;

        languageManager.EventLoadAllDone += LanguageLoadDoneEvent;
        inputKeysManager.EventLoadDone += InputKeysLoadDoneEvent;
        screenManager.EventLoadDone += ScreenLoadDoneEvent;
    }

    private void OnDestroy()
    {
        languageManager.EventLoadAllDone -= LanguageLoadDoneEvent;
        inputKeysManager.EventLoadDone -= InputKeysLoadDoneEvent;
        screenManager.EventLoadDone -= ScreenLoadDoneEvent;
    }


    private void LanguageLoadDoneEvent(List<UnityWebRequest> unityWebRequests)
    {
        languageRefresh?.Invoke();
    }
    private void InputKeysLoadDoneEvent(UnityWebRequest request)
    {
        if (!(request.isHttpError || request.isNetworkError))
        {
            inputKeyRefresh?.Invoke();
        }
    }

    private void ScreenLoadDoneEvent(UnityWebRequest request)
    {
        if (!(request.isHttpError || request.isNetworkError))
        {
            screenRefresh?.Invoke();
        }
    }



    #region GameSetData


    /// <summary>
    /// 加载默认设置数据
    /// </summary>
    public async Task LoadDataDefault()
    {
        await AsyncLoad(UnityWebRequest.Get(Application.streamingAssetsPath + Cd.PathGameDataDefault).SendWebRequest());
    }

    /// <summary>
    /// 加载设置数据
    /// </summary>
    public async Task LoadData()
    {
        await AsyncLoad(UnityWebRequest.Get(Application.streamingAssetsPath + Cd.PathGameData).SendWebRequest());
    }

    private async Task AsyncLoad(UnityWebRequestAsyncOperation asyncOperation)
    {
        var request = asyncOperation.webRequest;
        data = JsonMapper.ToObject<DataGameSet>(request.downloadHandler.text);

        await asyncOperation;

        if (!(request.isHttpError || request.isNetworkError))
        {
            await LoadLanguage();
            await LoadInputKeys();
            await LoadScreen();
        }
    }

    /// <summary>
    /// 保存设置数据
    /// </summary>
    public void SaveData()
    {
        File.WriteAllText(Application.streamingAssetsPath + Cd.PathGameData, Convert_String(JsonMapper.ToJson(data)));
    }
    #endregion


    #region Language

    /// <summary>
    /// 根据设置加载语言
    /// </summary>
    public async Task LoadLanguage()
    {
        languageManager.path = Cd.PathLanguageSwitch;
        languageManager.languageFolderName = data.Language;
        await languageManager.LoadAll();
    }

    #endregion

    #region InputKeys

    /// <summary>
    /// 加载按键绑定设置
    /// </summary>
    public async Task LoadInputKeys()
    {
        inputKeysManager.path = Cd.PathInputKeys;
        await inputKeysManager.Load();
    }

    /// <summary>
    /// 加载默认按键绑定设置
    /// </summary>
    public async Task LoadInputKeysDefault()
    {
        inputKeysManager.path = Cd.PathInputKeysDefault;
        await inputKeysManager.Load();
    }
    /// <summary>
    /// 保存按键绑定设置
    /// </summary>
    public void SaveInputKeys()
    {
        inputKeysManager.path = Cd.PathInputKeys;
        inputKeysManager.Save();
    }

    #endregion

    #region Screen


    /// <summary>
    /// 加载分辨率设置
    /// </summary>
    public async Task LoadScreen()
    {
        screenManager.path = Cd.PathScreenResolution;
        await screenManager.Load();
    }

    /// <summary>
    /// 加载默认分辨率设置
    /// </summary>
    public async Task LoadScreenDefault()
    {
        screenManager.path = Cd.PathScreenResolutionDefault;
        await screenManager.Load();
    }

    /// <summary>
    /// 保存分辨率设置
    /// </summary>
    public void SaveScreen()
    {
        screenManager.path = Cd.PathScreenResolution;
        screenManager.Save();
    }

    #endregion



    /// <summary>
    /// 乱码转换：用于解决LitJson把类转换成string时出现的乱码
    /// </summary>
    /// <param name="source">乱码字符串</param>
    /// <returns>正常字符串</returns>
    private string Convert_String(string source)
    {
        return new Regex(@"\\u([0-9A-F]{4})", RegexOptions.IgnoreCase)
        .Replace(source, x => string.Empty + Convert.ToChar(Convert.ToUInt16(x.Result("$1"), 16)));
    }

}


//游戏设置
public class DataGameSet
{
    public string Language = "中文";

    public float Volume = 0f;

}
