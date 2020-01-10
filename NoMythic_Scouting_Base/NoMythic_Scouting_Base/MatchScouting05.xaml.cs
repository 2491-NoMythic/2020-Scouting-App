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
            matchSuperVar.robotClimbed = true;
        }

        public void toggleShieldGeneratorBalanced(object sender, EventArgs e)
        {
            matchSuperVar.shieldGeneratorBalanced = true;
        }

        public void toggleRobotAssist(object sender, EventArgs e) 
        {
            matchSuperVar.robotAssisted = true;
            robotAssistNumber.IsVisible = true;
        }

        public void toggleAssistedRobots(object sender, EventArgs e)
        {
            matchSuperVar.assistedRobots = true;
        }

        public void selectRobotAssistNumber(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;

            if (selectedIndex != -1)
            {
                matchSuperVar.robotAssistAmount = (string)picker.ItemsSource[selectedIndex];
            }
        }

        async void MatchScoutNotesInit(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MatchScoutingNotes());
        }
    }
}