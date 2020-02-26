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
            matchSuperVar.lineCrossed = "true";
        }

        delegate void AutoVoidFunc();

        /*
        private void autoGenericInteraction(int ballChange, AutoVoidFunc updateAutoList)
        {
            if (matchSuperVar.ballStorageNumber > 0)
            {
                matchSuperVar.ballStorageNumber += ballChange;
                autoBallStorageCounter.Text = matchSuperVar.ballStorageNumber.ToString();
                updateAutoList();
            }
        }
        */

        private void autoGenericInteraction(int ballChange, AutoVoidFunc updateAutoInteraction)
        {
            if (matchSuperVar.ballStorageNumber > 0)
            {
                matchSuperVar.ballStorageNumber += ballChange;
                autoBallStorageCounter.Text = matchSuperVar.ballStorageNumber.ToString();
                updateAutoInteraction();
            }
        }

        public void autoBallIntakeGain(object sender, EventArgs e)
        {
            matchSuperVar.ballStorageNumber++;
            autoBallStorageCounter.Text = matchSuperVar.ballStorageNumber.ToString();

            matchSuperVar.autoPickupNumber++;
        }

        public void autoBallIntakeLoss(object sender, EventArgs e)
        {
            if (matchSuperVar.ballStorageNumber > 0)
            {
                matchSuperVar.ballStorageNumber--;
                autoBallStorageCounter.Text = matchSuperVar.ballStorageNumber.ToString();
            }
        }

        private void autoBallDropped(object sender, EventArgs e)
        {
            autoGenericInteraction(-1, () => matchSuperVar.autoDropNumber++);
        }

        private void autoBallScoredInner(object sender, EventArgs e)
        {
            autoGenericInteraction(-1, () => matchSuperVar.autoScoreInnerNumber++);
        }

        private void autoBallScoredOuter(object sender, EventArgs e)
        {
            autoGenericInteraction(-1, () => matchSuperVar.autoScoreOuterNumber++);
        }

        private void autoBallScoredBottom(object sender, EventArgs e)
        {
            autoGenericInteraction(-1, () => matchSuperVar.autoScoreLowerNumber++);
        }

        async void MatchScout04Init(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MatchScouting04());
        }
    }
}