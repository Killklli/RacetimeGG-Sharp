using System.Collections.Generic;

namespace RacetimeGG
{
    public class Ranking
    {
        /// <summary>
        /// User data blob.
        /// </summary>
        public User user { get; set; }
        /// <summary>
        /// The user's ranking as an integer, counting from 1 onward.
        /// </summary>
        public int place { get; set; }
        /// <summary>
        /// Same as place except it's an ordinal string, i.e. "1st", "2nd", "3rd", and so on.
        /// </summary>
        public string place_ordinal { get; set; }
        /// <summary>
        /// The user's calculated score, always a positive integer. Users who have never played start with a score of 833.
        /// </summary>
        public int score { get; set; }
        /// <summary>
        /// The users best overall time in a race.
        /// </summary>
        public string best_time { get; set; }
        /// <summary>
        /// The number of times the user has entered into recorded races for this goal (including DNF/DQ results).
        /// </summary>
        public int times_raced { get; set; }

    }

    public class Leaderboard
    {
        /// <summary>
        /// String name of the goal, e.g. "Beat the game".
        /// </summary>
        public string goal { get; set; }
        /// <summary>
        /// Total number of ranked participants for this leaderboard.
        /// </summary>
        public int num_ranked { get; set; }
        /// <summary>
        /// An ordered array of participants, starting from the highest ranked to the lowest.
        /// </summary>
        public List<Ranking> rankings { get; set; }

    }

    public class CategoryLeaderboards
    {
        /// <summary>
        /// The list of leaderboards associated with a category.
        /// </summary>
        public List<Leaderboard> leaderboards { get; set; }

    }


}
