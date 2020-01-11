﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NoMythic_Scouting_Base
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MatchScouting04 : ContentPage
    {
        MatchSuperVar matchSuperVar;
        Timer timer;
        public MatchScouting04()
        {
            InitializeComponent();
            matchSuperVar = MatchSuperVar.getInstance();
            timer = Timer.getInstance();

            teleopBallStorageCounter.Text = matchSuperVar.ballStorageNumber.ToString();
        }

        private void teleopBallIntakeGain(object sender, EventArgs e)
        {
            matchSuperVar.ballStorageNumber++;
            teleopBallStorageCounter.Text = matchSuperVar.ballStorageNumber.ToString();

            matchSuperVar.teleopPickups.Add(new MatchSuperVar.Pickup { pickupTime = timer.getTime() });
        }

        private void teleopBallIntakeLoss(object sender, EventArgs e)
        {
            if (matchSuperVar.ballStorageNumber > 0)
            {
                matchSuperVar.ballStorageNumber--;
                teleopBallStorageCounter.Text = matchSuperVar.ballStorageNumber.ToString();

                matchSuperVar.teleopPickups.RemoveAt(matchSuperVar.teleopPickups.Count - 1);
            }
        }

        private void teleopBallDropped(object sender, EventArgs e)
        {
            if (matchSuperVar.ballStorageNumber > 0)
            {
                matchSuperVar.ballStorageNumber--;
                teleopBallStorageCounter.Text = matchSuperVar.ballStorageNumber.ToString();

                matchSuperVar.teleopDrops.Add(new MatchSuperVar.Drop { dropTime = timer.getTime() });
            }
        }

        private void teleopBallScoredInner(object sender, EventArgs e)
        {
            if (matchSuperVar.ballStorageNumber > 0)
            {
                matchSuperVar.ballStorageNumber--;
                teleopBallStorageCounter.Text = matchSuperVar.ballStorageNumber.ToString();

                matchSuperVar.teleopScores.Add(new MatchSuperVar.Score { scoreTime = timer.getTime(), scoreLocation = "Inner" });
            }
        }

        private void teleopBallScoredOuter(object sender, EventArgs e)
        {
            if (matchSuperVar.ballStorageNumber > 0)
            {
                matchSuperVar.ballStorageNumber--;
                teleopBallStorageCounter.Text = matchSuperVar.ballStorageNumber.ToString();

                matchSuperVar.teleopScores.Add(new MatchSuperVar.Score { scoreTime = timer.getTime(), scoreLocation = "Outer" });
            }
        }

        private void teleopBallScoredBottom(object sender, EventArgs e)
        {
            if (matchSuperVar.ballStorageNumber > 0)
            {
                matchSuperVar.ballStorageNumber--;
                teleopBallStorageCounter.Text = matchSuperVar.ballStorageNumber.ToString();

                matchSuperVar.teleopScores.Add(new MatchSuperVar.Score { scoreTime = timer.getTime(), scoreLocation = "Bottom" });
            }
        }

        private void toggleControlPanelRotate(object sender, EventArgs e)
        {
            matchSuperVar.controlPanelRotated = true;
        }

        private void toggleControlPanelColorMatch(object sender, EventArgs e)
        {
            matchSuperVar.controlPanelColorMatched = true;
        }

        async void MatchScout05Init(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MatchScouting05());
        }
    }
}