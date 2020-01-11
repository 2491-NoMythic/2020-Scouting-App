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
        Timer timer;
        MatchSuperVar matchSuperVar;

        public MatchScouting03()
        {
            InitializeComponent();
            matchSuperVar = MatchSuperVar.getInstance();
            timer = Timer.getInstance();
            timer.Start();

            autoBallStorageCounter.Text = matchSuperVar.ballStorageNumber.ToString();
        }

        public void toggleLineCross(object sender, EventArgs e)
        {
            matchSuperVar.lineCrossed = true;
        }

        public void autoBallIntakeGain(object sender, EventArgs e)
        {
            matchSuperVar.ballStorageNumber++;
            autoBallStorageCounter.Text = matchSuperVar.ballStorageNumber.ToString();

            matchSuperVar.autoPickups.Add(new MatchSuperVar.Pickup { pickupTime = timer.getTime() });
        }

        public void autoBallIntakeLoss(object sender, EventArgs e)
        {
            if (matchSuperVar.ballStorageNumber > 0)
            {
                matchSuperVar.ballStorageNumber--;
                autoBallStorageCounter.Text = matchSuperVar.ballStorageNumber.ToString();

                matchSuperVar.autoPickups.RemoveAt(matchSuperVar.teleopPickups.Count - 1);
            }
        }

        private void autoBallDropped(object sender, EventArgs e)
        {
            if(matchSuperVar.ballStorageNumber > 0)
            {
                matchSuperVar.ballStorageNumber--;
                autoBallStorageCounter.Text = matchSuperVar.ballStorageNumber.ToString();

                matchSuperVar.autoDrops.Add(new MatchSuperVar.Drop { dropTime = timer.getTime() });
            }
        }

        private void autoBallScoredInner(object sender, EventArgs e)
        {
            if (matchSuperVar.ballStorageNumber > 0)
            {
                matchSuperVar.ballStorageNumber--;
                autoBallStorageCounter.Text = matchSuperVar.ballStorageNumber.ToString();
                matchSuperVar.autoScores.Add(new MatchSuperVar.Score { scoreTime = timer.getTime(), scoreLocation = "Inner" });
            }
        }

        private void autoBallScoredOuter(object sender, EventArgs e)
        {
            if (matchSuperVar.ballStorageNumber > 0)
            {
                matchSuperVar.ballStorageNumber--;
                autoBallStorageCounter.Text = matchSuperVar.ballStorageNumber.ToString();

                matchSuperVar.autoScores.Add(new MatchSuperVar.Score { scoreTime = timer.getTime(), scoreLocation = "Outer" });
            }
        }

        private void autoBallScoredBottom(object sender, EventArgs e)
        {
            if (matchSuperVar.ballStorageNumber > 0)
            {
                matchSuperVar.ballStorageNumber--;
                autoBallStorageCounter.Text = matchSuperVar.ballStorageNumber.ToString();

                matchSuperVar.autoScores.Add(new MatchSuperVar.Score { scoreTime = timer.getTime(), scoreLocation = "Bottom" });
            }
        }

        async void MatchScout04Init(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MatchScouting04());
        }
    }
}