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
    public partial class MatchScouting02 : ContentPage
    {
        public MatchScouting02()
        {
            InitializeComponent();
        }

        public void selectedPreloadedElementNumber(object sender, EventArgs e)
        {

        }

        async void MatchScout03Init(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MatchScouting03());
        }
    }
}