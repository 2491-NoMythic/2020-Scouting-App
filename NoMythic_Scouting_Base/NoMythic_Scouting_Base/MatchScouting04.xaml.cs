using System;
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

        delegate void TeleopVoidFunc();

        /*
        private void teleopGenericInteraction(int ballChange, TeleopVoidFunc updateTeleopList)
        {
            if (matchSuperVar.ballStorageNumber > 0)
            {
                matchSuperVar.ballStorageNumber += ballChange;
                teleopBallStorageCounter.Text = matchSuperVar.ballStorageNumber.ToString();
                updateTeleopList();
            }
        }
        */

        private void teleopGenericInteraction(int ballChange, TeleopVoidFunc updateTeleopInteraction)
        {
            if (matchSuperVar.ballStorageNumber > 0)
            {
                matchSuperVar.ballStorageNumber += ballChange;
                teleopBallStorageCounter.Text = matchSuperVar.ballStorageNumber.ToString();
                updateTeleopInteraction();
            }
        }


        private void teleopBallIntakeGain(object sender, EventArgs e)
        {
            matchSuperVar.ballStorageNumber++;
            teleopBallStorageCounter.Text = matchSuperVar.ballStorageNumber.ToString();

            //matchSuperVar.teleopPickups.Add(new MatchSuperVar.Pickup { pickupTime = timer.getTime() });
            matchSuperVar.teleopPickupNumber++;
        }

        private void teleopBallIntakeLoss(object sender, EventArgs e)
        {
            if (matchSuperVar.ballStorageNumber > 0)
            {
                matchSuperVar.ballStorageNumber--;
                teleopBallStorageCounter.Text = matchSuperVar.ballStorageNumber.ToString();
            }
        }

        private void teleopBallDropped(object sender, EventArgs e)
        {
            teleopGenericInteraction(-1, () => matchSuperVar.teleopDropNumber++);
        }

        private void teleopBallScoredInner(object sender, EventArgs e)
        {
            teleopGenericInteraction(-1, () => matchSuperVar.teleopScoreInnerNumber++);
        }

        private void teleopBallScoredOuter(object sender, EventArgs e)
        {
            teleopGenericInteraction(-1, () => matchSuperVar.teleopScoreOuterNumber++);
        }

        private void teleopBallScoredBottom(object sender, EventArgs e)
        {
            teleopGenericInteraction(-1, () => matchSuperVar.teleopScoreLowerNumber++);
        }

        private void toggleControlPanelRotate(object sender, EventArgs e)
        {
            matchSuperVar.controlPanelRotated = "true";
        }

        private void toggleControlPanelColorMatch(object sender, EventArgs e)
        {
            matchSuperVar.controlPanelColorMatched = "true";
        }

        async void MatchScout05Init(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MatchScouting05());
        }
    }
}