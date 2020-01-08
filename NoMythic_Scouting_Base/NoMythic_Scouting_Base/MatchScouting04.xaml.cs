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
        public MatchScouting04()
        {
            InitializeComponent();
        }

        private void initAutoShotMenu(object sender, EventArgs e)
        {

        }

        private void toggleControlPanelRotate(object sender, EventArgs e)
        {

        }

        private void toggleControlPanelColorMatch(object sender, EventArgs e)
        {

        }

        async void MatchScout05Init(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MatchScouting05());
        }
    }
}