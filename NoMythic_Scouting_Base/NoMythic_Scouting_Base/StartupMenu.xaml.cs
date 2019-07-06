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
    public partial class StartupMenu : ContentPage
    {
        public StartupMenu()
        {
            InitializeComponent();
        }

        async void MatchScoutInit(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MatchScouting01());
        }

        async void PitScoutInit(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PitScouting01());
        }

        async void ScheduleInputInit(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ScheduleInput());
        }
    }
}