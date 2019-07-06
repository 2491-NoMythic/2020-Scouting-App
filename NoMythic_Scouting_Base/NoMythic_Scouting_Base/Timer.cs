using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;

namespace NoMythic_Scouting_Base
{
    class Timer
    {
        Stopwatch mStopWatch = new Stopwatch();
        public void Start()
        {
            mStopWatch.Start();
        }
        void Stop()
        {
            mStopWatch.Stop();
            long elapsed = mStopWatch.ElapsedMilliseconds;
            String timeSpent = elapsed.ToString();
            mStopWatch.Reset();
        }
    }
}

