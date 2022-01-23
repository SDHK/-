using System.Collections;
using System.Collections.Generic;
using Singleton;
using UnityEngine;

namespace StateMachine
{
    public class FocusStateMachineManager : SingletonMonoBase<FocusStateMachineManager>
    {
        Dictionary<object, FocusStateMachine> focusStateMachines = new Dictionary<object, FocusStateMachine>();

        /// <summary>
        /// 获取对象绑定的状态机
        /// </summary>
        /// <param name="key">绑定的对象</param>
        public FocusStateMachine Get(object key)
        {
            if (focusStateMachines.ContainsKey(key))
            {
                return focusStateMachines[key];
            }
            else
            {
                FocusStateMachine focusStateMachine = new FocusStateMachine();
                focusStateMachines.Add(key, focusStateMachine);
                return focusStateMachine;
            }
        }

        /// <summary>
        /// 移除对象绑定的状态机
        /// </summary>
        /// <param name="key">绑定的对象</param>
        public void Remove(object key)
        {
            if (focusStateMachines.ContainsKey(key))
            {
                focusStateMachines.Remove(key);
            }
        }


        private void Update()
        {
            foreach (var focusStateMachine in focusStateMachines)
            {
                focusStateMachine.Value.Update();
            }
        }
    }
}