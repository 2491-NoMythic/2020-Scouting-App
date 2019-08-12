using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NoMythic_Scouting_Base
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MatchScouting03 : ContentPage
    {
        //public Timer timer;
        Stopwatch mStopWatch = new Stopwatch();
        private string timeSpent;

        public string TimeSpent
        {
            get { return this.timeSpent; }
        }

        public MatchScouting03()
        {
            InitializeComponent();
            //timer.Start();
            mStopWatch.Start();
        }

        public void MatchTimerStop()
        {
            //timer.Stop();
            mStopWatch.Stop();
            long elapsed = mStopWatch.ElapsedMilliseconds;
            string timeSpent = elapsed.ToString();
            mStopWatch.Reset();
        }

        public string TimerTime()
        {
            //return timer.TimeSpent;
            return TimeSpent;
        }

        async void MatchScout04Init(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MatchScouting04());
        }
    }
}