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
        }

        async void MatchScoutEndInit(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MatchScoutingEnd());
        }
    }
}