using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace StateMachine
{

    public static class FocusStateMachineExtension
    {

        /// <summary>
        /// 获取对象绑定的状态机
        /// </summary>
        public static FocusStateMachine FocusStateMachineGet(this object key)
        {
            return FocusStateMachineManager.Instance().Get(key);
        }

        /// <summary>
        /// 移除对象绑定的状态机
        /// </summary>
        /// <param name="key"></param>
        public static void FocusStateMachineRemove(this object key)
        {
            FocusStateMachineManager.Instance().Remove(key);
        }
    }
}