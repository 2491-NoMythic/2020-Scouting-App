﻿using System;
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
        MatchSuperVar matchSuperVar;

        public MatchScoutingNotes()
        {
            InitializeComponent();
            matchSuperVar = MatchSuperVar.getInstance();
        }

        public void autoNotes(object sender, EventArgs e)
        {
            autoEditor.Text = matchSuperVar.autoNotes;
        }

        public void teleopNotes(object sender, EventArgs e)
        {
            teleopEditor.Text = matchSuperVar.teleopNotes;
        }

        public void endgameNotes(object sender, EventArgs e)
        {
            endgameEditor.Text = matchSuperVar.endgameNotes;
        }
        public void slideDefense(object sender, EventArgs e)
        {
            matchSuperVar.defenseRating = defense.Value.ToString();
        }

        public void toggleControlPanelCrossing(object sender, EventArgs e)
        {
            matchSuperVar.controlPanelCrossing = "a";
        }

        async void MatchScoutEndInit(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MatchScoutingEnd());
        }
    }
}