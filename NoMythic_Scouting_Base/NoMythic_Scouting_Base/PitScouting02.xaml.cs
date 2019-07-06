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
    public partial class PitScouting02 : ContentPage
    {
        public PitScouting02()
        {
            InitializeComponent();
        }

        async void PitScout03Init(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PitScouting03());
        }
    }
}