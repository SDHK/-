




/******************************

 * 作者: 闪电黑客

 * 日期: 2021/02/27 17:00:56

 * 最后日期: 2021/02/27 17:01:36

 * 描述: 

******************************/



using System.Collections.Generic;
using TaskMachine;
using UnityEngine;

public class TestForeach : MonoBehaviour
{
    public List<int> listInt = new List<int>() { 1, 2, 3 };
    public List<int> listInt2 = new List<int>() { 1, 2 };

    public void Test0()
    {

        TaskManager.TaskRun()
        .Event(() => Debug.Log("开始遍历打印"))
        .Foreach(listInt,

        (item) =>
        {
            Debug.Log("遍历打印：" + item);
        })
        ;
    }


    public void Test1()
    {
        TaskManager.TaskRun()
        .Event(() => Debug.Log("开始嵌套遍历打印"))

        .Foreach(listInt,

        (item, TP1) =>
        {
            Debug.Log("外遍历打印：" + item);

            TP1.Insert()
            .Foreach(listInt2,
            (item2) =>
            {
                Debug.Log("内打印：" + item2);
            })
            ;
        })
        ;
    }

    public void Test2()
    {
        TaskManager.TaskRun(TaskModel.Update)   //开启进程（运行在update）
        .Event(() => Debug.Log("开始延迟遍历打印"))

        .Foreach(listInt,   //遍历List<int>

        (item, TP1) =>  //(内容，进程引用)
        {
            Debug.Log("外遍历打印：" + item);   //内容打印

            TP1.Insert(TaskModel.Thread)    //开启子进程（运行在多线程）
            .Foreach(listInt2,              //开启遍历任务（List<int> 2 ）
            (item2, TP2) =>                 
            {
                Debug.Log("内打印：" + item2);

                TP2.Insert(TaskModel.LateUpdate) //开启子子进程（运行在LateUpdate）
                .Delay(1)//延时1秒
                ; 
            })
            ;

        })
        ;
    }



}
