using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace EventActuator
{
    public abstract class EventNode
    {
        public bool isDone = false;
        public abstract void Update();
        public abstract void Recycle();
    }

}