﻿using System;
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
        public Timer timer;

        public MatchScouting03()
        {
            InitializeComponent();
            timer.Start();
        }

        public void MatchTimerStop()
        {
            timer.Stop();
        }

        public string TimerTime()
        {
            return timer.TimeSpent;
        }

        async void MatchScout04Init(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MatchScouting04());
        }
    }
}