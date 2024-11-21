using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabExercise11
{
    /// <summary>
    /// Class:  Score
    /// Author: Nicholas J. Corkigian
    /// Date:   November 22, 2019
    /// 
    /// Purpose: A score object has a player name, a value and
    ///          a time the score was obtained.
    ///          
    /// Note:    We make Score implement IComparable so that
    ///          we can pass Score objects into the Array.Sort()
    ///          method, and have them sorted based on our
    ///          customized criteria.
    ///          
    /// </summary>

    [Serializable()]
    class Score : IComparable<Score>
    {
        public string Player { get; }            // Player's name
        public int Rounds { get; }               // Score achieved
        public DateTime Date { get; }            // Date of game

        /// <summary>
        /// The constructor just creates a valid Score object.
        /// </summary>
        /// <param name="player">The player's name</param>
        /// <param name="rounds">The highest round achieved (score)</param>
        /// <param name="date">The date the game was played</param>
        public Score(string player, int rounds, DateTime date )
        {
            Player = player;
            Rounds = rounds;
            Date = date;
        }

        /// <summary>
        /// Used for adding to the Top Scores listbox.
        /// </summary>
        /// <returns>string representation of a Score</returns>
        public override string ToString()
        {
            return $"{Player} scored {Rounds} on {Date.ToString()}";
        }

        #region IComparable

        /// <summary>
        /// Scores should be sorted in descending order of the rounds
        /// completed.  In the case of a tie, scores should then be
        /// sorted based on arrival times.
        /// </summary>
        /// <param name="other">The other score to compare against</param>
        /// <returns>An integer that is either -1, 0, or 1 used by the Sort method</returns>
        public int CompareTo(Score other)
        {
            // A higher score goes ahead of a lower score
            if (this.Rounds != other.Rounds)
                return other.Rounds.CompareTo(this.Rounds);

            // If the scores are tied, the earlier score goes first
            else
                return this.Date.CompareTo(other.Date);
        }
        #endregion
    }
}
