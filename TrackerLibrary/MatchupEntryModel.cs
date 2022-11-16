using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Rep one team in matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Score for the team
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Rep match the team come from as winner
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
