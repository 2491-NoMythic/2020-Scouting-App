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
    public partial class PitScouting01 : ContentPage
    {
        PitSuperVar pitSuperVar;

        public PitScouting01()
        {
            InitializeComponent();
            pitSuperVar = PitSuperVar.getInstance();
        }

        void PitNameInput(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;

            if (selectedIndex != -1)
            {
                pitSuperVar.pitNameInput = (string)picker.SelectedItem;
            }
        }

        void PitTeamInput(object sender, EventArgs e)
        {
            pitSuperVar.pitTeamNum = ((Editor)sender).Text;
        }

        async void PitScout02Init(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PitScouting02());
        }
    }
}