


/******************************

 * 作者: 闪电黑客

 * 日期: 2021/02/23 13:44:46

 * 最后日期: 2021/02/23 13:45:02

 * 描述: 计时器

******************************/


using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Singleton;
using ObjectPool_;

namespace TimeClock
{
    public class Clock 
    {
        private float setTime_ = 0;
        private Action action;


        public bool isStart = false;
        public float nowTime_ = 0;


        public void Refresh()
        {
            isStart = true;
            nowTime_ = setTime_;
        }

        public Clock Initialize(float setTime_, Action action)
        {
            this.setTime_ = setTime_;
            this.action = action;
            return this;
        }


        public  void OnGet()
        {
            ClockManager.AddClock(this);
        }

        public  void OnRecycle()
        {
            isStart = false;
            setTime_ = 0;
            nowTime_ = 0;
            ClockManager.RemoveClock(this);
        }



        public void Update()
        {
            if (isStart)
            {
                nowTime_ -= Time.fixedDeltaTime;
                if (nowTime_ <= 0)
                {
                    if (action != null) action();
                    isStart = false;
                }
            }
        }
    }
}