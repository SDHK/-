using System.Collections;
using System.Collections.Generic;
using Singleton;
using UnityEngine;


namespace StateMachine
{
    public class StackStateMachineManager : SingletonMonoBase<StackStateMachineManager>
    {
        Dictionary<object, StackStateMachine> stackStateMachines = new Dictionary<object, StackStateMachine>();


        /// <summary>
        /// 获取对象绑定的状态机
        /// </summary>
        /// <param name="key">绑定的对象</param>
        public StackStateMachine Get(object key)
        {
            if (stackStateMachines.ContainsKey(key))
            {
                return stackStateMachines[key];
            }
            else
            {
                StackStateMachine focusStateMachine = new StackStateMachine();
                stackStateMachines.Add(key, focusStateMachine);
                return focusStateMachine;
            }
        }

        /// <summary>
        /// 移除对象绑定的状态机
        /// </summary>
        /// <param name="key">绑定的对象</param>
        public void Remove(object key)
        {
            if (stackStateMachines.ContainsKey(key))
            {
                stackStateMachines.Remove(key);
            }
        }

        private void Update()
        {
            foreach (var stackStateMachine in stackStateMachines)
            {
                stackStateMachine.Value.Update();
            }
        }
    }
}