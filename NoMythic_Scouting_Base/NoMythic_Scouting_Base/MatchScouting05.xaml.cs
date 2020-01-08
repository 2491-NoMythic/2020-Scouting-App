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
    public partial class MatchScouting05 : ContentPage
    {

        public MatchScouting05()
        {
            InitializeComponent();
            robotAssistNumber.IsVisible = false;
        }

        public void toggleRobotClimb(object sender, EventArgs e) 
        { 
            
        }

        public void toggleShieldGeneratorBalanced(object sender, EventArgs e)
        {

        }

        public void toggleRobotAssist(object sender, EventArgs e) 
        {
            robotAssistNumber.IsVisible = true;
        }

        public void toggleAssistedRobots(object sender, EventArgs e)
        {

        }

        public void selectRobotAssistNumber(object sender, EventArgs e)
        {

        }

        async void MatchScoutNotesInit(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MatchScoutingNotes());
        }
    }
}