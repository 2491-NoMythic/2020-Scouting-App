using System;
using System.Collections.Generic;
using System.Text;

namespace NoMythic_Scouting_Base
{
    interface IMatchInfoConvertable
    {
        string ToMatchInfoString();
    }
    class MatchSuperVar
    {
        private static MatchSuperVar matchSuperVar;

        /*
        //Ball Interaction Classes and Arrays
        public class Pickup: IMatchInfoConvertable
        {
            public string pickupTime { get; set; }
            public string ToMatchInfoString()
            {
                return pickupTime.ToString();
            }
        }

        public class Drop: IMatchInfoConvertable
        {
            public string dropTime { get; set; }

            public string ToMatchInfoString()
            {
                return dropTime.ToString();
            }
        }

        public class Score: IMatchInfoConvertable
        {
            public string scoreTime { get; set; }
            public string scoreLocation { get; set; }

            public string ToMatchInfoString()
            {
                return scoreTime.ToString() + "Y" + scoreLocation.ToString();
            }
        }

        public List<Pickup> autoPickups = new List<Pickup>();
        public List<Drop> autoDrops = new List<Drop>();
        public List<Score> autoScores = new List<Score>();

        public List<Pickup> teleopPickups = new List<Pickup>();
        public List<Drop> teleopDrops = new List<Drop>();
        public List<Score> teleopScores = new List<Score>();
        */

        //AppData
        public int ballStorageNumber = 0;
        public string scheduleInput;

        //QR Data
            //Opening Screen
        public string matchNameInputString;
        public string matchNumFinal;
        public string matchTeamNum;
            //Pregame
        public string preloadedElementAmount;
            //Auto
        public string lineCrossed = "false";
        //public string autoPickupString;
        //public string autoDropString;
        //public string autoScoreString;
        public int autoPickupNumber = 0;
        public int autoDropNumber = 0;
        public int autoScoreLowerNumber = 0;
        public int autoScoreOuterNumber = 0;
        public int autoScoreInnerNumber = 0;
            //Teleop
        public string controlPanelRotated = "false";
        public string controlPanelColorMatched = "false";
        //public string teleopPickupString;
        //public string teleopDropString;
        //public string teleopScoreString;
        public int teleopPickupNumber = 0;
        public int teleopDropNumber = 0;
        public int teleopScoreLowerNumber = 0;
        public int teleopScoreOuterNumber = 0;
        public int teleopScoreInnerNumber = 0;
            //Endgame
        public string robotClimbed = "false";
        public string shieldGeneratorBalanced = "false";
        public string robotAssisted = "false";
        public string assistedRobots = "false";
        public string robotAssistAmount;
            //Notes
        public string autoNotes;
        public string teleopNotes;
        public string endgameNotes;
        public string controlPanelCrossing = "false";
        public string defenseRating;

        public static MatchSuperVar getInstance()
        {
            if(matchSuperVar == null)
            {
                matchSuperVar = new MatchSuperVar();
            }
            return matchSuperVar;
        }

        /*
        public delegate string ScoreConverter<T>(T item);

        public string genericListScores<T>(List<T> interactionItems, ref string interactionAggregateString, string delimiter = "X") where T: IMatchInfoConvertable
        {
            for (int i = 0; i < interactionItems.Count; i++)
            {
                interactionAggregateString = interactionAggregateString + interactionItems[i].ToMatchInfoString() + delimiter;
            }
            return interactionAggregateString;
        }

        public string listAutoScores()
        {
            return genericListScores(matchSuperVar.autoScores, ref matchSuperVar.autoScoreString);
        }

        public string listAutoDrops()
        {
            return genericListScores(matchSuperVar.autoDrops, ref matchSuperVar.autoDropString);   
        }

        public string listAutoPickups()
        {
            return genericListScores(matchSuperVar.autoPickups, ref matchSuperVar.autoPickupString);
        }

        public string listTeleopScores()
        {
            return genericListScores(matchSuperVar.teleopScores, ref matchSuperVar.teleopScoreString);
        }

        public string listTeleopDrops()
        {
            return genericListScores(matchSuperVar.teleopDrops, ref matchSuperVar.teleopDropString);
        }

        public string listTeleopPickups()
        {
            return genericListScores(matchSuperVar.teleopPickups, ref matchSuperVar.teleopPickupString);
        }
        */
    }
}
