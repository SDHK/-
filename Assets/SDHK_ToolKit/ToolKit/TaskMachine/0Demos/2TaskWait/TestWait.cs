


/******************************

 * 作者: 闪电黑客

 * 日期: 2021/02/27 16:39:22

 * 最后日期: 2021/02/27 16:39:36

 * 描述: 

******************************/



using System;
using TaskMachine;
using UnityEngine;

public class TestWait : MonoBehaviour
{

    private Action callBack;

    public void Test0()
    {
        TaskManager.TaskRun()
        .Event(() =>
        {
            Debug.Log("条件判断等待（按下回车解除阻塞）");
        })
        .Wait(() => Input.GetKeyDown(KeyCode.Return))
        .Event(() =>
        {
            Debug.Log("阻塞解除");
        })
        ;
    }

    public void Test1()
    {
        TaskManager.TaskRun()

        .Stop((TP1) =>
        {
            Debug.Log("进程挂起等待");

            Debug.Log("回调注册，等待回调恢复运行");
            callBack = TP1.Continue;
        })
        .Event(() =>
        {
            Debug.Log("进程已恢复运行");

        })
        ;
    }

    public void Test1Continue()
    {
        if (callBack != null) callBack();
    }


}
