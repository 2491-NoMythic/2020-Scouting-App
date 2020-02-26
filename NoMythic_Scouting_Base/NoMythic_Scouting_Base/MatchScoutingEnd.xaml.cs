using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace NoMythic_Scouting_Base
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MatchScoutingEnd : ContentPage
    {
        ZXingBarcodeImageView matchBarcode;
        Timer timer;
        MatchSuperVar matchSuperVar;

        public MatchScoutingEnd()
        {
            InitializeComponent();
            timer = Timer.getInstance();
            matchSuperVar = MatchSuperVar.getInstance();
            timer.Stop();
        }

        private void MatchGenerateQR(object sender, EventArgs e)
        {
            matchBarcode = new ZXingBarcodeImageView
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                AutomationId = "zxingBarcodeImageView",
            };
            matchBarcode.BarcodeFormat = ZXing.BarcodeFormat.QR_CODE;
            matchBarcode.BarcodeOptions.Width = 600;
            matchBarcode.BarcodeOptions.Height = 600;
            string finalMatchData = "Match Number" + "%%%" + "Team Number" + "%%%" + "Scout Name" + "%%%" + "Preloaded Elements" + "%%%" + "Line Crossed" + "%%%" + "Pickups in Auto" + "%%%" + "Dropped Balls in Auto" + "%%%" 
                + "Lower Scores in Auto" + "%%%" + "Outer Scores in Auto" + "%%%" + "Inner Scores in Auto" + "%%%" + "Pickups in Teleop" + "%%%" + "Dropped Balls in Teleop" + "%%%" + "Lower Scores in Teleop" + "%%%" + "Outer Scores in Teleop" + "%%%" + "Inner Scores in Teleop" + "%%%" + "Control Panel rotated" + "%%%" + "Control Panel Color Matched" + "%%%" + "Robot Climbed" + "%%%"
                + "Shield Generator Balanced" + "%%%" + "Robot Assisted" + "%%%" + "Assisted Robots" + "%%%" + "Number of Robots Assisted" + "%%%" + "Notes on Auto" + "%%%" + "Notes on Teleop" + "%%%" + "Notes on Endgame" + "%%%"
                + "Defense Rating" + "%%%" + "Crossed Under Control Panel" + "QQQ-+-&"
                + matchSuperVar.matchNumFinal + "%%%" + matchSuperVar.matchTeamNum + "%%%" + matchSuperVar.matchNameInputString + "%%%" + matchSuperVar.preloadedElementAmount + "%%%" + matchSuperVar.lineCrossed + "%%%"
                + matchSuperVar.autoPickupNumber.ToString() + "%%%" + matchSuperVar.autoDropNumber.ToString() + "%%%" + matchSuperVar.autoScoreLowerNumber.ToString() + "%%%" + matchSuperVar.autoScoreOuterNumber.ToString() + "%%%" + matchSuperVar.autoScoreInnerNumber.ToString() + "%%%" + matchSuperVar.teleopPickupNumber.ToString() + "%%%" + matchSuperVar.teleopDropNumber.ToString() + "%%%"
                + matchSuperVar.teleopScoreLowerNumber.ToString() + "%%%" + matchSuperVar.teleopScoreOuterNumber.ToString() + "%%%" + matchSuperVar.teleopScoreInnerNumber.ToString() + "%%%" + matchSuperVar.controlPanelRotated + "%%%" + matchSuperVar.controlPanelColorMatched + "%%%" + matchSuperVar.robotClimbed + "%%%" + matchSuperVar.shieldGeneratorBalanced + "%%%"
                + matchSuperVar.robotAssisted + "%%%" + matchSuperVar.assistedRobots + "%%%" + matchSuperVar.robotAssistAmount + "%%%" + matchSuperVar.autoNotes + "%%%" + matchSuperVar.teleopNotes + "%%%" + matchSuperVar.endgameNotes + "%%%"
                + matchSuperVar.defenseRating + "%%%" + matchSuperVar.controlPanelCrossing;

            int len = matchBarcode.BarcodeValue.Length;
            matchBarcode.BarcodeValue = finalMatchData;
            matchLayout.Children.Insert(0, matchBarcode);
        }

        async void MatchReturnHome(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}