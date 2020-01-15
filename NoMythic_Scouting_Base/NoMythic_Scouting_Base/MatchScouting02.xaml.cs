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
        MatchSuperVar matchSuperVar;

        public MatchScouting02()
        {
            InitializeComponent();
            matchSuperVar = MatchSuperVar.getInstance();
        }

        public void selectPreloadedElementNumber(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;

            if(selectedIndex != -1)
            {
                matchSuperVar.ballStorageNumber = (selectedIndex + 1);
                matchSuperVar.preloadedElementAmount = (selectedIndex + 1).ToString();
            }
        }

        async void MatchScout03Init(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MatchScouting03());
        }
    }
}