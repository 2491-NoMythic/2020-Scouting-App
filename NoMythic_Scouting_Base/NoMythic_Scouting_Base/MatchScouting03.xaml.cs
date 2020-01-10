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

            autoBallStorageCounter.Text = matchSuperVar.autoBallStorageNumber.ToString();
        }

        public void toggleLineCross(object sender, EventArgs e)
        {
            matchSuperVar.lineCrossed = true;
        }

        public void ballIntakeGain(object sender, EventArgs e)
        {
            matchSuperVar.autoBallStorageNumber = matchSuperVar.autoBallStorageNumber++;
            autoBallStorageCounter.Text = matchSuperVar.autoBallStorageNumber.ToString();
        }

        public void ballIntakeLoss(object sender, EventArgs e)
        {
            matchSuperVar.autoBallStorageNumber = matchSuperVar.autoBallStorageNumber--;
            autoBallStorageCounter.Text = matchSuperVar.autoBallStorageNumber.ToString();
        }

        private void initAutoShotMenu(object sender, EventArgs e)
        {

        }

        async void MatchScout04Init(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MatchScouting04());
        }
    }
}