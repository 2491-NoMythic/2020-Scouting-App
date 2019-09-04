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
        string pitNameInput;

        public PitScouting01()
        {
            InitializeComponent();
        }

        void PitNameInput(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;

            if (selectedIndex != -1)
            {
                pitNameInput = (string)picker.SelectedItem;
            }
        }

        void PitTeamInput(object sender, EventArgs e)
        {
            string pitTeamNum = ((Editor)sender).Text;
        }

        async void PitScout02Init(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PitScouting02());
        }
    }
}