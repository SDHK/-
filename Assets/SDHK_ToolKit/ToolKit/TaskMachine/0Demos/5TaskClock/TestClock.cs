




/******************************

 * 作者: 闪电黑客

 * 日期: 2021/02/27 16:18:31

 * 最后日期: 2021/02/27 16:20:03

 * 描述: 

******************************/



using System.Collections.Generic;
using TaskMachine;
using UnityEngine;

public class TestClock : MonoBehaviour
{

    public List<int> Times = new List<int>() { 1, 2, 3, 4, 5 };


    public void Test0()
    {
        TaskManager.TaskRun()
        .Event((T) => T.ClockReset())

        .ClockSet(1, () => { Debug.Log("第1秒"); })
        .ClockSet(2, () => { Debug.Log("第2秒"); })
        .ClockSet(3, () => { Debug.Log("第3秒"); })
        .ClockSet(4, () => { Debug.Log("第4秒"); })
        .ClockSet(5, () => { Debug.Log("第5秒"); })
        ;
    }


    public void Test1()
    {
        TaskManager.TaskRun()
        .Event((T) => T.ClockReset())
        .Foreach(Times, (time, TP1) =>
        {
            TP1.ClockSet(time, () =>
            {
                Debug.Log("第" + time + "秒" + "UDP发送...");
            });
        })
        ;

    }
}
