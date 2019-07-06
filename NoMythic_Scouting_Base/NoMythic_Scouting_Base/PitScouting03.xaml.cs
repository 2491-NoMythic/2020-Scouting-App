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
    public partial class PitScouting03 : ContentPage
    {
        public PitScouting03()
        {
            InitializeComponent();
        }

        async void PitScoutEndInit(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PitScoutingEnd());
        }
    }
}