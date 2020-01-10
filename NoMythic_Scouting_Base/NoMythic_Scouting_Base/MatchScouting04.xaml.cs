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

        public MatchScouting04()
        {
            InitializeComponent();
            matchSuperVar = MatchSuperVar.getInstance();
        }

        private void initAutoShotMenu(object sender, EventArgs e)
        {

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