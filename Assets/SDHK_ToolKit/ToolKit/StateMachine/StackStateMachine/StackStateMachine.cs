using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;


namespace StateMachine
{

    /// <summary>
    /// 堆栈状态机
    /// </summary>
    public class StackStateMachine
    {
        /// <summary>
        /// 状态列表
        /// </summary>
        public List<IStackState> States = new List<IStackState>();

        private bool isEnterDone = true;
        private bool isExitDone = true;

        private IStackState nextPushState = null;
        private IStackState nextPopState = null;


        /// <summary>
        /// 出栈回调，每个状态出栈时
        /// </summary>
        public Action<IStackState> PopCallBack;

        /// <summary>
        /// 栈顶提醒回调，请求出栈状态不是栈顶时（栈顶）
        /// </summary>
        public Action<IStackState> StackTopCallBack;


        /// <summary>
        /// 状态完成
        /// </summary>
        public bool IsDone => isEnterDone && isExitDone;

        /// <summary>
        /// 状态进入完成
        /// </summary>
        public bool IsEnterDone => isEnterDone;

        /// <summary>
        /// 状态退出完成
        /// </summary>
        public bool IsExitDone => isExitDone;

        /// <summary>
        /// 数量
        /// </summary>
        public int Count => States.Count;

        public object Current => throw new NotImplementedException();

        //消除为null的栈顶        
        private void StackClearNull()
        {
            for (int i = States.Count - 1; i >= 0; i--)
            {
                if (States[i] == null)
                {
                    States.RemoveAt(i);
                }
                else
                {
                    break;
                }
            }
        }

        /// <summary>
        /// 获取栈顶
        /// </summary>
        public IStackState Peek()
        {
            return States.Count == 0 ? null : States[States.Count - 1];
        }


        /// <summary>
        /// 请求入栈
        /// </summary>
        public bool Push(IStackState state)
        {
            bool bit = IsDone && !States.Contains(state) && state != null;
            if (bit)
            {
                nextPushState = state;
                isEnterDone = false;
                nextPushState.stackStateMachine = this;
                nextPushState.WaitStackStateEnter(EnterDone);
            }
            return bit;
        }

        /// <summary>
        /// 请求状态出栈：若请求不是栈顶，则会提示栈顶
        /// </summary>
        public bool Pop(IStackState state)
        {
            if (IsDone)
            {

                StackClearNull();
                if (States.Count > 0)
                {
                    if (States[States.Count - 1] == state)
                    {
                        nextPopState = States[States.Count - 1];
                        isExitDone = false;
                        state.WaitStackStateExit(ExitDone);
                        return true;
                    }
                    StackTopCallBack?.Invoke(States[States.Count - 1]);
                }
            }

            return false;
        }

        /// <summary>
        /// 请求栈顶出栈
        /// </summary>
        public bool Pop()
        {
            if (IsDone)
            {
                StackClearNull();
                if (States.Count > 0)
                {
                    nextPopState = States[States.Count - 1];
                    isExitDone = false;
                    nextPopState.WaitStackStateExit(ExitDone);
                    return true;
                }
            }
            return false;
        }



        //进入完成回调
        private void EnterDone()
        {
            isEnterDone = true;
            States.Add(nextPushState);
            nextPushState?.StackStateEnter();
            nextPushState = null;
        }

        //离开完成回调
        private void ExitDone()
        {
            isExitDone = true;

            nextPopState?.StackStateExit();
            States.Remove(nextPopState);
            PopCallBack?.Invoke(nextPopState);

            nextPopState = null;
        }


        /// <summary>
        /// 清空
        /// </summary>
        public void Clear()
        {
            States.Clear();
            nextPushState = null;
            nextPopState = null;
            isEnterDone = true;
            isExitDone = true;
        }

        /// <summary>
        /// 状态机刷新
        /// </summary>
        public void Update()
        {
            for (int i = States.Count - 1; i >= 0; i--)
            {
                if (States[i] == null)
                {
                    States.RemoveAt(i);
                }
                else
                {
                    States[i].StackStateUpdate();
                }
            }
        }










    }
}