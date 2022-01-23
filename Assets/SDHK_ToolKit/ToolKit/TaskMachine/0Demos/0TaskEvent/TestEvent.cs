

/******************************

 * 作者: 闪电黑客

 * 日期: 2021/02/27 10:57:14

 * 最后日期: 2021/02/27 10:58:00

 * 描述: 

******************************/



using TaskMachine;
using UnityEngine;

public class TestEvent : MonoBehaviour
{
    public GameObject cube;

    private void Update()
    {
        // if (Input.GetKey(KeyCode.V))
        // {

        //     Test3();
        // }

    }

    public void Test0()
    {
        TaskManager.TaskRun()
        .Event(() =>
        {
            Debug.Log("事件1");
        })
        .Event((TP1) =>
        {
            Debug.Log("事件2");
        })
        .Event(() =>
        {
            Debug.Log("事件3");
        })
        

        ;

    }

    public void Test1()
    {
        TaskManager.TaskRun()
        .Event(() =>
        {
            Debug.Log("事件1");
        })
        .Event(() =>
        {
            Debug.Log("事件2");
        })
        .Event(() =>
        {
            Debug.Log("事件3");
        })
        ;

        TaskManager.TaskRun()
       .Event(() =>
       {
           Debug.Log("委托1");
       })
       .Event(() =>
       {
           Debug.Log("委托2");
       })
       .Event(() =>
       {
           Debug.Log("委托3");
       })
       ;

        TaskManager.TaskRun()
       .Event(() =>
       {
           Debug.Log("打印1");
       })
       .Event(() =>
       {
           Debug.Log("打印2");
       })
       .Event(() =>
       {
           Debug.Log("打印3");
       })
       ;

        TaskManager.TaskRun();
    }


    public void Test2()
    {
        TaskManager.TaskRun(TaskModel.Update)
        .Event(() =>
        {
            Debug.Log("Update1");
        })
        .Event(() =>
        {
            Debug.Log("Update2");
        })
        .Event(() =>
        {
            Debug.Log("Update3");
        })
        ;

        TaskManager.TaskRun(TaskModel.LateUpdate)
        .Event(() =>
        {
            Debug.Log("LateUpdate1");
        })
        .Event(() =>
        {
            Debug.Log("LateUpdate2");
        })
        .Event(() =>
        {
            Debug.Log("LateUpdate3");
        })
        ;

        TaskManager.TaskRun(TaskModel.FixedUpdate)
        .Event(() =>
        {
            Debug.Log("FixedUpdate1");
        })
        .Event(() =>
        {
            Debug.Log("FixedUpdate2");
        })
        .Event(() =>
        {
            Debug.Log("FixedUpdate3");

        })

        ;

        TaskManager.TaskRun(TaskModel.Thread)
        .Event(() =>
        {
            // Thread.Sleep(1000);
            Debug.Log("Thread1");
        })
        .Event(() =>
        {
            // Thread.Sleep(1000);
            Debug.Log("Thread2");
        })
        .Event(() =>
        {
            // Thread.Sleep(1000);
            Debug.Log("Thread3");
        })
        ;

    }

    public void Test3()
    {
        TaskManager.TaskRun(TaskModel.Update)
        .Event(() =>
        {
            Debug.Log("打印1");
        })
        .Event((TP12) =>
        {
            Debug.Log("打印2");


            TP12.Insert(TaskModel.Update)
            .Event(() =>
            {

                Debug.Log("子进程打印1");
            })
            .Event((TP2) =>
            {
                Debug.Log("子进程打印2");



                TP2.Insert(TaskModel.Update)
                .Event((tp3) =>
                {
                    Debug.Log("子进程2:打印1");
                    // tp3.Release();
                })
                 .Event(() =>
                {
                    Debug.Log("子进程2:打印2");
                })
                 .Event(() =>
                {
                    Debug.Log("子进程2:打印3");
                })
                ;

                TP2.Insert(TaskModel.Update)
                .Event((tp3) =>
                {
                    Debug.Log("子进程21:打印1");
                    // tp3.Release();
                })
                 .Event(() =>
                {
                    Debug.Log("子进程21:打印2");
                })
                 .Event(() =>
                {
                    Debug.Log("子进程21:打印3");
                })
                ;


            })
            .Event(() =>
            {
                Debug.Log("子进程打印3");
            })
            .Event(() =>
            {
                Debug.Log("子进程打印4");
            })
            ;

            Debug.Log("打印2.1");


        })
        .Event(() =>
        {
            Debug.Log("打印3");
        })
         .Event(() =>
        {
            Debug.Log("打印4");
        })
        ;
    }

    public void Test4()
    {
        TaskManager.TaskRun()
        .Event(() =>
        {
            Debug.Log("打印1");
        })
        .Event((Tp1) =>
        {
            Tp1.Coroutine()
            .Event(() =>
            {
                Debug.Log("协程1");
            })
            .Event(() =>
            {
                Debug.Log("协程2");
            })
            .Event(() =>
            {
                Debug.Log("协程3");
            })
            ;
        })
        .Event(() =>
        {
            Debug.Log("打印2");
        })
        .Event(() =>
        {
            Debug.Log("打印3");
        })
        ;
    }


    public void Test5()
    {

        cube.TaskRun()
        .Event(() =>
        {
            Debug.Log("绑定任务1");
        })
        .Event(() =>
        {
            Debug.Log("绑定任务2");
        })
        .Event(() =>
        {
            Debug.Log("绑定任务3");
        })
        .Event((TP1) =>
        {
            Debug.Log("绑定任务4");
            Destroy(cube);
        })
        .Event(() =>
        {
            Debug.Log("绑定任务5");
        })
        .Event(() =>
        {
            Debug.Log("绑定任务6");
        })
        ;

    }
}
