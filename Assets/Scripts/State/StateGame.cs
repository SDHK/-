using System;
using System.Collections;
using System.Collections.Generic;
using Singleton;
using StateMachine;
using UnityEngine;



public class StateGame : SingletonBase<StateGame>, IFocusState
{
    public FocusStateMachine focusStateMachine { get; set; }

    public void FocusStateEnter()
    {
        Debug.Log("StateGame启动！");
    }

    public void FocusStateExit()
    {
        Debug.Log("StateGame退出！");

    }



    public void WaitFocusStateEnter(Action EnterDone)
    {
        EnterDone();
    }

    public void WaitFocusStateExit(Action ExitDone)
    {
        ExitDone();
    }

    public void FocusStateUpdate()
    {
       
    }
}
