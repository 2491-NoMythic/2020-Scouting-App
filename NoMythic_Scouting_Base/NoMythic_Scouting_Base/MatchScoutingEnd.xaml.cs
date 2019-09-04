﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;
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
            timeRecog.Text = timer.getTimeSpent();
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
            matchBarcode.BarcodeValue = matchSuperVar.matchNumFinal + matchSuperVar.matchTeamNum + matchSuperVar.matchNameInputString;

            matchLayout.Children.Insert(0, matchBarcode);
        }

        async void MatchReturnHome(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}