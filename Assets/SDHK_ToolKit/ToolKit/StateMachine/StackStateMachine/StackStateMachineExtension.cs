using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StateMachine
{

    public static class StackStateMachineExtension
    {
        public static StackStateMachine StackStateMachineGet(this object key)
        {
            return StackStateMachineManager.Instance().Get(key);
        }

        public static void StackStateMachineRemove(this object key)
        {
            StackStateMachineManager.Instance().Remove(key);
        }

    }
}