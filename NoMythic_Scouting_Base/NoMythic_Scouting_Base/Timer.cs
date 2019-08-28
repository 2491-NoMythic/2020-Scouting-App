using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;

namespace NoMythic_Scouting_Base
{
    public class Timer
    {

        private Stopwatch mStopWatch;
        private static Timer timer;
        private string timeSpent;

        public Timer()
        {
            mStopWatch = new Stopwatch();
        }

        public static Timer getInstance()
        {
            if(timer == null)
            {
                timer = new Timer();
            }
            return timer;
        }

        public string getTimeSpent()
        {
            return this.timeSpent;
        }

        public void Start()
        {
            mStopWatch.Start();
        }

        public void Stop()
        {
            mStopWatch.Stop();
            long elapsed = mStopWatch.ElapsedMilliseconds;
            timeSpent = elapsed.ToString();
            mStopWatch.Reset();
        }

        public string getTime()
        {
            long currentTime = mStopWatch.ElapsedMilliseconds;
            string eventTime = currentTime.ToString();
            return eventTime;
        }
    }
}

