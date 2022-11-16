using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Reps one match in a tournament
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// Set of team involved in the match
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; }
        /// <summary>
        /// Match winner
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Round the match belongs to 
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
