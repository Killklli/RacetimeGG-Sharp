using System;
using System.Collections.Generic;

namespace RacetimeGG
{
    public class Race
    {
        /// <summary>
        /// The race's unique name, based on the category and a randomly assigned slug.
        /// </summary>
        public string name { get; set;  }
        /// <summary>
        /// An object giving brief information about the race's status.
        /// </summary>
        public Status status { get; set;  }
        /// <summary>
        /// URL for the main race page.
        /// </summary>
        public string url { get; set;  }
        /// <summary>
        /// URL for the race data endpoint, which you can use to obtain more detailed race information.
        /// </summary>
        public string data_url { get; set;  }
        /// <summary>
        /// An object describing the race goal.
        /// </summary>
        public Goal goal { get; set;  }
        /// <summary>
        /// String containing additional information for race entrants, as set by the monitors.
        /// </summary>
        public string info { get; set;  }
        /// <summary>
        /// Total number of entrants in this race (including DQ/forfeits).
        /// </summary>
        public int entrants_count { get; set;  }
        /// <summary>
        /// Total number of entrants that have been DQed or forfieted.
        /// </summary>
        public int entrants_count_inactive { get; set;  }
        /// <summary>
        /// Date/time when the race was first created (ISO 8601 date).
        /// </summary>
        public DateTime opened_at { get; set;  }
        /// <summary>
        /// Date/time when the race started, or null if it hasn't started yet (ISO 8601 date).
        /// </summary>
        public DateTime started_at { get; set;  }
        /// <summary>
        /// The maximum amount of time the race may be in progress for once it starts (ISO 8601 duration).
        /// </summary>
        public string time_limit { get; set;  }
        /// <summary>
        /// Date/time when the race ended, or null if it hasn't finished yet (ISO 8601 date).
        /// </summary>
        public DateTime ended_at { get; set;  }
        /// <summary>
        /// Date/time when the race was cancelled, or null if it hasn't been cancelled (ISO 8601 date).
        ///     Note: a race may be cancelled at any point before it's finished. If it was cancelled before the race started, started_at and ended_at will not be set. If it was cancelled after the race started, started_at will be set and ended_at will be equal to cancelled_at.
        /// </summary>
        public object cancelled_at { get; set;  }
        /// <summary>
        /// Boolean indicating a race can be recorded once it's finished. A moderator may still opt to not record the race.
        /// </summary>
        public bool recordable { get; set;  }
        /// <summary>
        /// Boolean indicating if the race has been recorded by a moderator.
        /// </summary>
        public bool recorded { get; set;  }

    }
    public class Status
    {
        /// <summary>
        /// A machine-parsable status text. Possible values are:
        ///         open
        ///         invitational
        ///         pending
        ///         in_progress
        ///         finished
        ///         cancelled
        /// </summary>
        public string value { get; set;  }
        /// <summary>
        /// A user-parsable status text, e.g. "In progress".
        /// </summary>
        public string verbose_value { get; set;  }
        /// <summary>
        /// Describes the status, e.g. "Race is in progress".
        /// </summary>
        public string help_text { get; set;  }

    }
    public class PastRaces
    {
        /// <summary>
        /// The number of races the user has been in.
        /// </summary>
        public int count { get; set;  }
        /// <summary>
        /// The number of pages total
        /// </summary>
        public int num_pages { get; set;  }
        /// <summary>
        /// The list of Races a user has been in.
        /// </summary>
        public List<Race> races { get; set;  }

    }
    public class Goal
    {
        /// <summary>
        /// A string value indicating the current goal.
        /// </summary>
        public string name { get; set;  }
        /// <summary>
        /// A boolean indicating if the goal name was custom, or one of the pre-set category goals.
        /// </summary>
        public bool custom { get; set;  }

    }

    public class User
    {
        /// <summary>
        /// A unique identifier for this user. Will remain the same even if the user changes their display name. IDs are always strings.
        /// </summary>
        public string id { get; set;  }
        /// <summary>
        /// A unique user display name, including their original display name and their scrim. Note that some users may not have a scrim, in which case full_name will be the same as name.
        /// </summary>
        public string full_name { get; set;  }
        /// <summary>
        /// Just the user's display name. If you don't need an unambigiously unique name for the user, you can use this field. Otherwise you should use full_name.
        /// </summary>
        public string name { get; set;  }
        /// <summary>
        /// The discriminator (or scrim) is used to disambiguate identical display names. It is typically set to a random 4-digit string. Note that the scrim may start with 0 (e.g. "Bowser#0340"), so you should not treat this field as an integer. May be set to null if the user has no discriminator.
        /// </summary>
        public string discriminator { get; set;  }
        /// <summary>
        /// URL for the user's profile page.
        /// </summary>
        public string url { get; set;  }
        /// <summary>
        /// URL for the user's avatar picture, or null if the user has no avatar.
        /// </summary>
        public object avatar { get; set;  }
        /// <summary>
        /// String indicating the user's preferred pronouns, or null if user has not set any pronouns.
        /// </summary>
        public object pronouns { get; set;  }
        /// <summary>
        /// The user's current flair, as a set of space-separated strings. This is used to indicate how the user should be styled. It should not be used to determine logical information, e.g. if a user is a moderator.
        /// </summary>
        public string flair { get; set;  }
        /// <summary>
        /// The user's connected Twitch account name, capitalised according to how they've set it on Twitch. Will be null if the user has no connected Twitch account.
        /// </summary>
        public string twitch_name { get; set;  }
        /// <summary>
        /// The absolute URI for the user's connected Twitch account channel page. Will be null if the user has no connected Twitch account.
        /// </summary>
        public string twitch_channel { get; set;  }
        /// <summary>
        /// A boolean indicating if the user is a moderator. This is context-sensitive, as moderator status varies per category. If there is no category in context, this will always be false (even if user is staff).
        /// </summary>
        public bool can_moderate { get; set;  }

    }
}
