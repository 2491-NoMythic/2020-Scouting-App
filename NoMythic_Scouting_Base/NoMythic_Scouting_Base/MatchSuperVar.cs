using System;
using System.Collections.Generic;
using System.Text;

namespace NoMythic_Scouting_Base
{
    class MatchSuperVar
    {
        private static MatchSuperVar matchSuperVar;

        //AppData
        public int autoBallStorageNumber = 0;

        //QR Data
            //Opening Screen
        public string matchNameInputString;
        public string matchNumFinal;
        public string matchTeamNum;
            //Pregame
        public string preloadedElementAmount;
            //Auto
        public Boolean lineCrossed = false;
            //Teleop
        public Boolean controlPanelRotated = false;
        public Boolean controlPanelColorMatched = false;
            //Endgame
        public Boolean robotClimbed = false;
        public Boolean shieldGeneratorBalanced = false;
        public Boolean robotAssisted = false;
        public Boolean assistedRobots = false;
        public string robotAssistAmount;
            //Notes
        public string autoNotes;
        public string teleopNotes;
        public string endgameNotes;
        public Boolean controlPanelCrossing = false;
        public string defenseRating;

        public static MatchSuperVar getInstance()
        {
            if(matchSuperVar == null)
            {
                matchSuperVar = new MatchSuperVar();
            }
            return matchSuperVar;
        }
    }
}
