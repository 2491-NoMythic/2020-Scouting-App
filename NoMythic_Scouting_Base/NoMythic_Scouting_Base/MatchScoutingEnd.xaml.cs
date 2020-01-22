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
            string finalMatchData = matchSuperVar.matchNumFinal + "%%%" + matchSuperVar.matchTeamNum + "%%%" + matchSuperVar.matchNameInputString +"QQQ-+-&"
                + matchSuperVar.preloadedElementAmount + "%%%" + matchSuperVar.lineCrossed + "%%%" + matchSuperVar.listAutoPickups() + "%%%" + matchSuperVar.listAutoDrops() + "%%%" + matchSuperVar.listAutoScores() + "%%%"
                + matchSuperVar.listTeleopPickups() + "%%%" + matchSuperVar.listTeleopDrops() + "%%%" + matchSuperVar.listTeleopScores() + "%%%" + matchSuperVar.controlPanelRotated + "%%%" + matchSuperVar.controlPanelColorMatched + "%%%"
                + matchSuperVar.robotClimbed + "%%%" + matchSuperVar.shieldGeneratorBalanced + "%%%" + matchSuperVar.robotAssisted + "%%%" + matchSuperVar.assistedRobots + "%%%" + matchSuperVar.robotAssistAmount + "%%%"
                + matchSuperVar.autoNotes + "%%%" + matchSuperVar.teleopNotes + "%%%" + matchSuperVar.endgameNotes + "%%%" + matchSuperVar.defenseRating + "%%%" + matchSuperVar.controlPanelCrossing;

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