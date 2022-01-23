using System.Collections;
using System.Collections.Generic;
using Singleton;
using UnityEngine;


namespace TimeClock
{

    public class ClockManager : SingletonMonoBase<ClockManager>
    {
        private List<Clock> clocks = new List<Clock>();

        public static void AddClock(Clock clock)
        {
            if (!Instance().clocks.Contains(clock))
            {
                instance.clocks.Add(clock);
            }
        }

        public static void RemoveClock(Clock clock)
        {
            if (Instance().clocks.Contains(clock))
            {
                instance.clocks.Remove(clock);
            }
        }

        private void FixedUpdate()
        {
            for (int i = clocks.Count-1; i > 0; i--)
            {
                clocks[i].Update();
            }
        }




    }
}