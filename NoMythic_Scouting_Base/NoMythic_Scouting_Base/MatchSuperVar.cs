using System;
using System.Collections.Generic;
using System.Text;

namespace NoMythic_Scouting_Base
{
    class MatchSuperVar
    {
        private static MatchSuperVar matchSuperVar;

        //Ball Interaction Classes and Arrays
        public class Pickup
        {
            public string pickupTime { get; set; }
        }

        public class Drop
        {
            public string dropTime { get; set; }
        }

        public class Score
        {
            public string scoreTime { get; set; }
            public string scoreLocation { get; set; }
        }

        public List<Pickup> autoPickups = new List<Pickup>();
        public List<Drop> autoDrops = new List<Drop>();
        public List<Score> autoScores = new List<Score>();

        public List<Pickup> teleopPickups = new List<Pickup>();
        public List<Drop> teleopDrops = new List<Drop>();
        public List<Score> teleopScores = new List<Score>();

        //AppData
        public int ballStorageNumber = 0;

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
