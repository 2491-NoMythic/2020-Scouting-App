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

        public void doEditorExample(object sender, EventArgs e)
        {
            exText.Text = exEditor.Text;
        }

        public void exPickerMove(object sender, EventArgs e)
        {
            
        }

        public void doReveal(object sender, EventArgs e)
        {
            exText.Text = "lmao";
        }

        public void getNaeNaed(object sender, EventArgs e)
        {
            exText.Text = "get nae naed boomer";
        }

        async void MatchScout03Init(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MatchScouting03());
        }
    }
}