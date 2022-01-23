using System.Collections;
using System.Collections.Generic;
using Singleton;
using UnityEngine;

using ObjectPool_;
using System;
using System.Threading;
using System.Runtime.CompilerServices;

namespace TaskExecutor
{
    public static class Extensions1
    {
        public static AsyncAwait GetAwaiter(this SynchronizationContext scontext)
        {
            return new AsyncAwait(scontext);
        }
    }

    //异步模式切换器
    public partial class AsyncModel
    {
        public static int UnityThreadID { get; set; }
        public static SynchronizationContext ToUnity { get; private set; }
        public static SynchronizationContext ToThread { get; private set; }

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void AsyncUtilityInitlize()
        {
            UnityThreadID = Thread.CurrentThread.ManagedThreadId;//获取unity的线程ID
            ToUnity = SynchronizationContext.Current;//获取unity的线程上下文Context

            ToThread = new SynchronizationContext();
        }
    }

    public struct ContextAwaiter : INotifyCompletion
    {
        public bool IsCompleted => true;//这个应该是控制阻塞完成的

        public ContextAwaiter GetAwaiter()
        {
            return this;
        }

        public void OnCompleted(Action continuation)
        {
        }
        public void GetResult() { }

    }

    public interface IAwaitNode : INotifyCompletion
    {
        bool IsCompleted { get; }
    }
    public interface IAwaitNode<out T> : IAwaitNode
    {
        T Result { get; }
        T GetResult();
    }


    //异步等待
    public class AsyncAwait : IAwaitNode
    {
        private SynchronizationContext context;

        public AsyncAwait(SynchronizationContext context)
        {
            this.context = context;
        }
        public bool IsCompleted => context == SynchronizationContext.Current;


        public void OnCompleted(Action continuation)//continuation的作用是调用后可以继续运行
        {
            context.Post(PostCallBack, continuation);//启动一个线程回调callBakc,
        }

        private void PostCallBack(object continuation)
        {
            ((Action)continuation)();//继续运行
        }

        public void GetResult() { }
    }







    public partial class EventExecutorManager
    {
        private List<EventExecutor> lateUpdates = new List<EventExecutor>();

        public void AddLateUpdate(EventExecutor taskActuator)
        {
            if (!lateUpdates.Contains(taskActuator))
            {
                taskActuator.isRun = isRun;
                lateUpdates.Add(taskActuator);
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
    }

    public partial class EventExecutorManager
    {
        private List<EventExecutor> fixedUpdates = new List<EventExecutor>();

        public void AddFixedUpdate(EventExecutor taskActuator)
        {
            if (!fixedUpdates.Contains(taskActuator))
            {
                taskActuator.isRun = isRun;
                fixedUpdates.Add(taskActuator);
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

    public partial class EventExecutorManager
    {
        private List<EventExecutor> threadUpdates = new List<EventExecutor>();

        public void AddThreadUpdates(EventExecutor taskActuator)
        {
            if (!threadUpdates.Contains(taskActuator))
            {
                taskActuator.isRun = isRun;
                taskActuator.RunThread();
                threadUpdates.Add(taskActuator);
            }
        }
    }

    public partial class EventExecutorManager : SingletonMonoBase<EventExecutorManager>
    {
        public bool isRun = true;

        private List<EventExecutor> updates = new List<EventExecutor>();

        public void AddUpdate(EventExecutor taskActuator)
        {
            if (!updates.Contains(taskActuator))
            {
                taskActuator.isRun = isRun;
                updates.Add(taskActuator);
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

    }


    /// <summary>
    /// 任务执行器:一个执行器执行一个进程
    /// </summary>
    public partial class EventExecutor : IObjectPoolItem
    {
        private static ObjectPool<EventExecutor> pool = new ObjectPool<EventExecutor>()
        { clock = 600 }
        .RegisterManager();

        private EventExecutor() { }
        public static EventExecutor Get() => pool.Get();

        public void Recycle() => pool.Recycle(this);


        public List<EventChain> eventChains = new List<EventChain>();

        public bool isDone = false;
        public bool isRun = true;

        private Thread thread;

        public void RunThread()
        {
            if (thread == null)
            {
                thread = new Thread(ThreadUpdate) { IsBackground = true };
            }
            thread.Start();
        }

        private void ThreadUpdate()
        {
            while (!isDone)
            {
                Update();
                Thread.Sleep(1);
            }
        }



        public void Update()
        {
            if (isRun)
            {
                if (eventChains.Count > 0)
                {
                    isDone = false;
                    if (eventChains[eventChains.Count - 1].isDone)
                    {
                        eventChains[eventChains.Count - 1].Recycle();
                        eventChains.RemoveAt(eventChains.Count - 1);
                    }
                    else
                    {
                        eventChains[eventChains.Count - 1].Update();
                    }
                }
                else
                {
                    isDone = true;
                }
            }
        }


        public void ObjectOnNew() { }
        public void ObjectOnClear() { }
        public void ObjectOnGet() { isDone = false; }
        public void ObjectOnRecycle()
        {
            isRun = false;
            foreach (var eventList in eventChains)
            {
                eventList.Recycle();
            }
            eventChains.Clear();
            thread.Abort();
        }

    }

    public class EventChain : IObjectPoolItem
    {
        private static ObjectPool<EventChain> pool = new ObjectPool<EventChain>()
        { clock = 600 }
        .RegisterManager();

        private EventChain() { }
        public static EventChain Get() => pool.Get();
        public void Recycle() => pool.Recycle(this);

        public int eventPointer = 0;
        public bool isDone = false;
        private List<EventNode> events = new List<EventNode>();//当前进程任务队列



        public void ObjectOnNew() { }
        public void ObjectOnClear() { }
        public void ObjectOnGet() { isDone = false; eventPointer = 0; }
        public void ObjectOnRecycle()
        {
            foreach (var task in events)
            {
                task.Recycle();
            }
            events.Clear();
        }


        /// <summary>
        /// 添加一个任务节点
        /// </summary>
        /// <param name="taskNode">任务节点</param>
        /// <returns>当前任务进程</returns>
        public EventChain Add(EventNode taskNode)
        {
            events.Add(taskNode);
            return this;
        }

        public void Update()
        {
            if (eventPointer < events.Count)
            {
                isDone = false;
                if (events[eventPointer].isDone)
                {
                    eventPointer++;
                }
                else
                {
                    events[eventPointer].Update();
                }
            }
            else
            {
                isDone = true;
            }

        }
    }



    public abstract class EventNode
    {
        public bool isDone = false;
        public abstract void Update();
        public abstract void Recycle();
    }

    public class EventAction : EventNode, IObjectPoolItem
    {
        private static ObjectPool<EventAction> pool = new ObjectPool<EventAction>()
        { clock = 600 }
        .RegisterManager();

        public Action action;

        public static EventAction Get(Action action)
        {
            var node = EventAction.pool.Get();
            node.action = action;
            return node;
        }

        public void ObjectOnNew() { }
        public void ObjectOnClear() { }
        public void ObjectOnGet() { }

        public void ObjectOnRecycle()
        {
            action = null;
        }

        public override void Update()
        {
            action?.Invoke();
        }

        public override void Recycle()
        {
            pool.Recycle(this);
        }
    }




    public partial class EventExecutor
    {
        // public TaskActuator Event(Action action)
        // {
        //     taskProcess.Add(EventAction.Get(action));
        //     return this;
        // }

        // public TaskActuator Event(Action<TaskActuator> action)
        // {
        //     taskProcess.Add(TaskEvent_.Get(this, action));
        //     return this;
        // }
    }




}