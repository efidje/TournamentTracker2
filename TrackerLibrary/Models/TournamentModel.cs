﻿using System.Collections.Generic;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents one tournament, with all of the rounds, prizes and outcome
    /// </summary>
    public class TournamentModel
    {
        /// <summary>
        /// The name given to this tournament
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// The ammount of money each team needs to put up to enter
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// The set of teams that have been entered
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// The list of prizes for the various places
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// The matchups per round
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();

    }
}
