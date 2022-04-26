using UnityEngine.SceneManagement;
using UnityEngine;
using AssetBandleTool;
using System.Linq;
using System;
using XLua;
using Singleton;
using StateMachine;
using System.Threading;
using System.Threading.Tasks;
using System.Linq.Expressions;
using UnityEngine.UI;
using CoroutineSystem;
using AsyncAwaitEvent;
using UnityEngine.Networking;
using SDHK_Extension;
using System.IO;
using ObjectFactory;
using EventDelegate_;
using UnityEngine.Events;
using PathAssets;
using LitJson;
using System.Collections.Generic;
using UnityEditor;
using DG.Tweening;
using UnityEngine.Rendering.Universal;
using EventMachine;
using System.Collections;

public class GameManager : SingletonMonoEagerBase<GameManager>
{

    async void Start()
    {

        await AsyncMode.ToUnity;

        PathAssetLoader pathAssetLoader = new PathAssetLoader(Application.dataPath + "/AssetBundles/StandaloneWindows", "StandaloneWindows");

        pathAssetLoader.EventLoadAllDone += (downloadHandler) =>
                {
                    PathAssetGlobal.Assets = downloadHandler.pathAsset;
                };
        await pathAssetLoader.LoadAll();

        await Task.Delay(100);

        LuaManager.Instance().Run(" require 'luatool/LuaToolRequires.lua'");

        // 测试AssetDatabase加载
        // Debug.Log(PathAssetGlobal.Assets.Get<string>("LanguageSwitch", "English", "主界面", "设置"));

    }










    // public static string GetPropertyName<T>(Expression<Func<T, string>> expr)
    // {
    //     var name = ((MemberExpression)expr.Body).Member.Name;
    //     return name;
    // }



}





















