


/******************************

 * 作者: 闪电黑客

 * 日期: 2021/02/27 14:29:28

 * 最后日期: 2021/02/27 14:30:22

 * 描述: 

******************************/



using UnityEngine;
using TaskMachine;
using UnityEngine.UI;

public class TestDelay : MonoBehaviour
{

    public Text text1;

    public void Test0()
    {

        TaskManager.TaskRun()
        .Event(() =>
        {
            Debug.Log("延迟启动");
        })
        .Delay(1)
        .Event(() =>
        {
            Debug.Log("延迟1秒后");
        })
        .Delay(2)
        .Event(() =>
        {
            Debug.Log("延迟2秒后");
        })
        .Delay(3)
        .Event(() =>
        {
            Debug.Log("延迟3秒后");
        })
        ;
    }

    public void Test1()
    {
        TaskManager.TaskRun()
        .Event(() =>
        {
            Debug.Log("延迟计时启动");
        })
        .Delay(5, (time) =>
        {
            text1.text = time + "";
        })
        .Event(() =>
        {
            Debug.Log("计时完毕");
        })
        ;
    }

    public void Test2()
    {
        TaskManager.TaskRun()
        .Event(() =>
        {
            Debug.Log("超时等待启动");
        })
        .TimeOutWait(5, () => Input.GetKeyDown(KeyCode.Return),
        (bit) =>
        {
            if (bit)
            {
                Debug.Log("超时回调");
            }
            else
            {
                Debug.Log("未超时回调");

            }
        })
        .Event(() =>
        {
            Debug.Log("等待结束");
        })
        ;

    }


    public void Test3()
    {
        TaskManager.TaskRun()
        .Event(() =>
        {
            Debug.Log("超时重置启动");
        })
        .TimeOutReset(3, () => Input.GetKeyDown(KeyCode.Return),
        () =>
        {
            Debug.Log("超时触发");
        }
        )
        .Event(() =>
        {
            Debug.Log("等待结束");
        })
        ;
    }
}
