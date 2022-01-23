using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using FSM;
using AssetBandleTool;

using SDHK_Extension;
using WindowUI;
using StateMachine;
using Singleton;
using UnityEngine.SceneManagement;

/// <summary>
/// 状态：主界面状态
/// </summary>
public class StateMainMenu : SingletonBase<StateMainMenu>, IFocusState
{
    public FocusStateMachine focusStateMachine { get; set; }


    public void WaitFocusStateEnter(Action EnterDone)
    {
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(Cd.SceneGameMenu);//异步加载场景

        // asyncOperation.allowSceneActivation = false;  //不允许在加载完场景后自动切换
        // T1.Insert().Wait(() => Input.GetKeyDown(KeyCode.Return), () => asyncOperation.allowSceneActivation = true);

        //切换后才会调用
        asyncOperation.completed += (p) => EnterDone();
    }

    public void FocusStateEnter()
    {
        Debug.Log("StateMainMenu启动！");
        WindowMain.pool.WindowShow();
    }

    public void FocusStateExit()
    {
        WindowManager.Instance().RecycleAll();
        Debug.Log("StateMainMenu退出！");
    }


    public void WaitFocusStateExit(Action ExitDone)
    {
        ExitDone();
    }
    public void FocusStateUpdate()
    {

    }
}
