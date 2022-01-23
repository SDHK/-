



/******************************

 * 作者: 闪电黑客

 * 日期: 2021/02/27 17:30:10

 * 最后日期: 2021/02/27 17:30:53

 * 描述: 

******************************/



using TaskMachine;
using UnityEngine;

public class TestFor : MonoBehaviour
{
    public void Test0()
    {

        TaskManager.TaskRun()
        .While(() => !Input.GetKeyDown(KeyCode.Return),
        () =>
        {
            Debug.Log("条件循环,按回车跳出循环");
        })
        .Event(() =>
        {
            Debug.Log("已跳出循环");
        })
        ;


    }

    public void Test1()
    {
        TaskManager.TaskRun()
        .For(5,
        (i) =>
        {
            Debug.Log("计数循环：" + i);
        })
        .Event(() =>
        {
            Debug.Log("循环结束");
        })
        ;


    }

    public void Test2()
    {
        TaskManager.TaskRun()
        .For(2, 5, (i) =>
        {
            Debug.Log("逼近循环:" + i);
        })
        ;
    }

    public void Test3()
    {
        TaskManager.TaskRun()
        .For(0, (i) => i < 5,
        (i) =>
        {
            Debug.Log("For:" + i);

            return 1;
        })
        ;
    }
}
