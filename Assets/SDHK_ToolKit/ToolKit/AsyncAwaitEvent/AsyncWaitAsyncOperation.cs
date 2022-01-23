
/******************************

 * 作者: 闪电黑客

 * 日期: 2021/12/02 16:29:00

 * 最后日期: 。。。

 * 描述: 
    
    Async/Await的功能扩展
    等待 AsyncOperation结束，用法和协程一样

    使用:
        await request.SendWebRequest(); 
    

******************************/


using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;



namespace AsyncAwaitEvent
{

    public static class AsyncWaitAsyncOperationExtension
    {
        public static AsyncWaitAsyncOperation GetAwaiter(this AsyncOperation asyncOperation)
        {
            return new AsyncWaitAsyncOperation(asyncOperation);
        }
    }

    /// <summary>
    /// AsyncAwait 的 AsyncOperation 等待事件
    /// </summary>
    public class AsyncWaitAsyncOperation : IAsyncAwaitNode
    {
        public AsyncWaitAsyncOperation GetAwaiter() => this; //await需要这个;

        public bool IsCompleted => isDone;
        private bool isDone = false;

        private AsyncOperation asyncOperation;
        public AsyncWaitAsyncOperation(AsyncOperation asyncOperation)
        {
            this.asyncOperation = asyncOperation;
        }

        public void OnCompleted(Action continuation)
        {
            CoroutineFunc(continuation);
        }

        private async void CoroutineFunc(Action continuation)
        {
            while (!asyncOperation.isDone)
            {
                await Task.Delay(10);
            }
            isDone = true;
            continuation();//继续运行
        }

        public void GetResult() { }
    }


    
}