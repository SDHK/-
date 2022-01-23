using System.Collections;
using System.Collections.Generic;
using Singleton;
using UnityEngine;


namespace EventActuator
{
    public partial class EventExecutorManager : SingletonMonoBase<EventExecutorManager>
    {
        public bool isRun = true;

        private List<EventExecutor> updates = new List<EventExecutor>();
        private List<EventExecutor> lateUpdates = new List<EventExecutor>();
        private List<EventExecutor> fixedUpdates = new List<EventExecutor>();
        private List<EventExecutor> threadUpdates = new List<EventExecutor>();

        public void AddUpdate(EventExecutor taskActuator)
        {
            if (!updates.Contains(taskActuator))
            {
                taskActuator.isRun = isRun;
                updates.Add(taskActuator);
            }
        }
        public void AddLateUpdate(EventExecutor taskActuator)
        {
            if (!lateUpdates.Contains(taskActuator))
            {
                taskActuator.isRun = isRun;
                lateUpdates.Add(taskActuator);
            }
        }
        public void AddFixedUpdate(EventExecutor taskActuator)
        {
            if (!fixedUpdates.Contains(taskActuator))
            {
                taskActuator.isRun = isRun;
                fixedUpdates.Add(taskActuator);
            }
        }

        public void AddThreadUpdates(EventExecutor taskActuator)
        {
            if (!threadUpdates.Contains(taskActuator))
            {
                taskActuator.isRun = isRun;
                taskActuator.RunThread();
                threadUpdates.Add(taskActuator);
            }
        }


        private void Update()
        {
            for (int i = updates.Count - 1; i >= 0; i--)
            {
                updates[i].Update();
                if (updates[i].isDone)
                {
                    updates[i].Recycle();
                    updates.RemoveAt(i);
                }
            }

            for (int i = threadUpdates.Count - 1; i >= 0; i--)
            {
                if (threadUpdates[i].isDone)
                {
                    threadUpdates[i].Recycle();
                    threadUpdates.RemoveAt(i);
                }
            }
        }

        private void LateUpdate()
        {
            for (int i = lateUpdates.Count - 1; i >= 0; i--)
            {
                lateUpdates[i].Update();
                if (lateUpdates[i].isDone)
                {
                    lateUpdates[i].Recycle();
                    lateUpdates.RemoveAt(i);
                }
            }
        }

        private void FixedUpdate()
        {
            for (int i = fixedUpdates.Count - 1; i >= 0; i--)
            {
                fixedUpdates[i].Update();
                if (fixedUpdates[i].isDone)
                {
                    fixedUpdates[i].Recycle();
                    fixedUpdates.RemoveAt(i);
                }
            }
        }

    }
}