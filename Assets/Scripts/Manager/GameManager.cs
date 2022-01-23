using UnityEngine.SceneManagement;
using UnityEngine;
// using TaskMachine;
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
using TaskExecutor;
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



//!Language加载需要修改（大改）

[LuaCallCSharp]
public class TastTable001
{
    public string str = "A1";

    public void pr1(int a)
    {
        Debug.Log("str!!!:"+a);
    }
}

public class GameManager : SingletonMonoEagerBase<GameManager>
{

    /// <summary>
    /// 预设数值
    /// </summary>
    public static GameValue value;

    private ModelGameSet modelGameSet;

    public UnityEvent<int> a;
    public UnityAction<int> a1;

    public static string GetPropertyName<T>(Expression<Func<T, string>> expr)
    {
        var name = ((MemberExpression)expr.Body).Member.Name;
        return name;
    }


    async void Start()
    {
        await AsyncMode.ToUnity;

        PathAssetLoader pathAssetLoader = new PathAssetLoader(Application.dataPath + Cd.PathAB, Cd.PathABmainName);
        pathAssetLoader.EventLoadAllDone += (downloadHandler) =>
        {
            PathAssetGlobal.Assets = downloadHandler.pathAsset;
        };
        Debug.Log("等待");
        await pathAssetLoader.LoadAll();
        Debug.Log("等待1");

        LuaManager.Instance().Run(" require 'luatool/LuaToolRequires.lua'");

        // var box = GetComponent<BoxCollider>();


        // modelGameSet = ModelGameSet.Instance();
        // await modelGameSet.LoadData();

        // //加载预定数值
        // value = Cd.ABgameValue.ABLoadAsset<GameValue>(Cd.AB_GameValue);

        // //画布实例化
        // GameObject.DontDestroyOnLoad(Instantiate(Cd.ABpfb_ui.ABLoadAsset<GameObject>(Cd.AB_UICanvasBox)));
        // //鼠标实例化
        // MouseCursor.Instance().Initialize();

        // Debug.Log("资源加载完成");

        // Cd.FSMgame.FocusStateMachineGet().Set(StateMainMenu.Instance());


    }














}





















