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
    public partial class MatchScouting01 : ContentPage
    {
        int matchNum;
        string matchTeamNum;
        string matchNameInputString;
        int deviceNum = 1;
        ScheduleInput scheduleInput;

        public MatchScouting01()
        {
            InitializeComponent();
            scheduleInput = ScheduleInput.getInstance();
            matchTeamNumInput.IsVisible = false;
        }

        void MatchNameInput(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;

            if (selectedIndex != -1)
            {
                matchNameInputString = (string)picker.SelectedItem;
            }
        }

        void MatchInput(object sender, EventArgs e)
        {
            matchNum = Int32.Parse(((Editor)sender).Text);
            String matchNumFinal = ((Editor)sender).Text;
            int splitNum = deviceNum + ((matchNum - 1) * 6);
            if (scheduleInput.getSchedule() != null)
            {
                matchTeamNum = scheduleInput.getSchedule().Split(',')[splitNum];
            }
        }      

        void DisplayRobotNum(object sender, EventArgs e)
        {
            matchTeamNumInput.IsVisible = true;
        }

        void MatchTeamInput(object sender, EventArgs e)
        {
            matchTeamNum = ((Editor)sender).Text;
        }

        async void MatchScout02Init(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MatchScouting02());
        }
    }
}