using System;
using System.Collections.Generic;
using System.Text;

namespace NoMythic_Scouting_Base
{
    class PitSuperVar
    {
        private static PitSuperVar pitSuperVar;
        public string pitTeamNum;
        public string pitNameInput;

        public static PitSuperVar getInstance()
        {
            if(pitSuperVar == null)
            {
                pitSuperVar = new PitSuperVar();
            }
            return pitSuperVar;
        }
    }
}
