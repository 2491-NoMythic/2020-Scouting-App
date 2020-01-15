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

        MatchSuperVar matchSuperVar;

        public MatchScouting05()
        {
            InitializeComponent();
            matchSuperVar = MatchSuperVar.getInstance();
            robotAssistNumber.IsVisible = false;
        }

        public void toggleRobotClimb(object sender, EventArgs e) 
        {
            matchSuperVar.robotClimbed = "a";
        }

        public void toggleShieldGeneratorBalanced(object sender, EventArgs e)
        {
            matchSuperVar.shieldGeneratorBalanced = "a";
        }

        public void toggleRobotAssist(object sender, EventArgs e) 
        {
            matchSuperVar.robotAssisted = "a";
        }

        public void toggleAssistedRobots(object sender, EventArgs e)
        {
            matchSuperVar.assistedRobots = "a";
            robotAssistNumber.IsVisible = true;
        }

        public void selectRobotAssistNumber(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;

            if (selectedIndex != -1)
            {
                matchSuperVar.robotAssistAmount = (selectedIndex + 1).ToString();
            }
        }

        async void MatchScoutNotesInit(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MatchScoutingNotes());
        }
    }
}