
/******************************

 * Author: 闪电黑客

 * 日期: 2021/12/20 18:27:34

 * 最后日期: 2022/01/22 22:41:53

 * 最后修改: 闪电黑客

 * 描述:  
    
    LuaMono对象池对象

    连接Lua和mono脚本
    让 Lua 拥有 MonoBehaviour 的生命周期以及事件响应功能

******************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;
using System;


namespace ObjectFactory
{
    public class LuaMonoObject : MonoBehaviour
    {
        public LuaTable table;


        #region Start

        public Action MonoStart;
        private void Start()
        {
            MonoStart?.Invoke();
        }

        public Action MonoOnDestroy;
        private void OnDestroy()
        {
            MonoOnDestroy?.Invoke();
        }
        #endregion


        #region Update

        public Action MonoUpdate;
        private void Update()
        {
            MonoUpdate?.Invoke();
        }

        public Action MonoLateUpdate;
        private void LateUpdate()
        {
            MonoLateUpdate?.Invoke();
        }

        public Action MonoFixedUpdate;
        private void FixedUpdate()
        {
            MonoFixedUpdate?.Invoke();
        }

        #endregion


        #region OnEnable
        public Action MonoOnEnable;
        private void OnEnable()
        {
            MonoOnEnable?.Invoke();
        }

        public Action MonoOnDisable;
        private void OnDisable()
        {
            MonoOnDisable?.Invoke();
        }
        #endregion


        #region OnCollision

        public Action<Collision> MonoOnCollisionEnter;
        private void OnCollisionEnter(Collision other)
        {
            MonoOnCollisionEnter?.Invoke(other);
        }

        public Action<Collision> MonoOnCollisionStay;
        private void OnCollisionStay(Collision other)
        {
            MonoOnCollisionStay?.Invoke(other);
        }

        public Action<Collision> MonoOnCollisionExit;
        private void OnCollisionExit(Collision other)
        {
            MonoOnCollisionExit?.Invoke(other);
        }

        public Action<Collision2D> MonoOnCollisionEnter2D;
        private void OnCollisionEnter2D(Collision2D other)
        {
            MonoOnCollisionEnter2D?.Invoke(other);
        }
        public Action<Collision2D> MonoOnCollisionStay2D;
        private void OnCollisionStay2D(Collision2D other)
        {
            MonoOnCollisionStay2D?.Invoke(other);
        }

        public Action<Collision2D> MonoOnCollisionExit2D;
        private void OnCollisionExit2D(Collision2D other)
        {
            MonoOnCollisionExit2D?.Invoke(other);
        }



        #endregion


        #region OnTrigger
        public Action<Collider> MonoOnTriggerEnter;
        private void OnTriggerEnter(Collider other)
        {
            MonoOnTriggerEnter?.Invoke(other);
        }
        public Action<Collider> MonoOnTriggerStay;
        private void OnTriggerStay(Collider other)
        {
            MonoOnTriggerStay?.Invoke(other);
        }
        public Action<Collider> MonoOnTriggerExit;

        private void OnTriggerExit(Collider other)
        {
            MonoOnTriggerExit?.Invoke(other);
        }

        public Action<Collider2D> MonoOnTriggerEnter2D;
        private void OnTriggerEnter2D(Collider2D other)
        {
            MonoOnTriggerEnter2D?.Invoke(other);
        }

        public Action<Collider2D> MonoOnTriggerStay2D;
        private void OnTriggerStay2D(Collider2D other)
        {
            MonoOnTriggerStay2D?.Invoke(other);
        }
        public Action<Collider2D> MonoOnTriggerExit2D;
        private void OnTriggerExit2D(Collider2D other)
        {
            MonoOnTriggerExit2D?.Invoke(other);
        }



        #endregion


        #region OnApplication

        public Action MonoOnApplicationQuit;
        private void OnApplicationQuit()
        {
            MonoOnApplicationQuit?.Invoke();
        }

        public Action<bool> MonoOnApplicationFocus;
        private void OnApplicationFocus(bool focusStatus)
        {
            MonoOnApplicationFocus?.Invoke(focusStatus);
        }

        public Action<bool> MonoOnApplicationPause;
        private void OnApplicationPause(bool pauseStatus)
        {
            MonoOnApplicationPause?.Invoke(pauseStatus);
        }

        #endregion


    }
}


