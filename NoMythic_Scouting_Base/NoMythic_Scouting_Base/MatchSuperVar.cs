using System;
using System.Collections.Generic;
using System.Text;

namespace NoMythic_Scouting_Base
{
    class MatchSuperVar
    {
        private static MatchSuperVar matchSuperVar;
        public string matchNameInputString;
        public string matchNumFinal;
        public string matchTeamNum;

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
