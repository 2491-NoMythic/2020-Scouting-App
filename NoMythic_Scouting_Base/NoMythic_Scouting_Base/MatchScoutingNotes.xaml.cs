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
    public partial class MatchScoutingNotes : ContentPage
    {
        public MatchScoutingNotes()
        {
            InitializeComponent();
        }

        public void autoNotes(object sender, EventArgs e)
        {
            
        }

        public void teleopNotes(object sender, EventArgs e)
        {

        }

        public void endgameNotes(object sender, EventArgs e)
        {

        }

        async void MatchScoutEndInit(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MatchScoutingEnd());
        }
    }
}