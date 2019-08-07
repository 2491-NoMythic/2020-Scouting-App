using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;

namespace NoMythic_Scouting_Base
{
    public class Timer
    {
        Stopwatch mStopWatch = new Stopwatch();
        private string timeSpent;

        public string TimeSpent
        {
            get { return this.timeSpent; }
        }

        public void Start()
        {
            mStopWatch.Start();
        }
        public void Stop()
        {
            mStopWatch.Stop();
            long elapsed = mStopWatch.ElapsedMilliseconds;
            string timeSpent = elapsed.ToString();
            mStopWatch.Reset();
        }
    }
}

