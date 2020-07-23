using System;
using System.Collections.Generic;

namespace RacetimeGG
{

    public class Entrant
    {
        /// <summary>
        /// User data blob for this entrant.
        /// </summary>
        public User user { get; set;  }
        /// <summary>
        /// An object describing the entrant's current status.
        /// </summary>
        public Status status { get; set;  }
        /// <summary>
        /// The user's final finish time, or null if they've not finished (ISO 8601 duration).
        /// </summary>
        public object finish_time { get; set;  }
        /// <summary>
        /// The date/time when the user finished, or null if they've not finished (ISO 8601 date).
        /// </summary>
        public object finished_at { get; set;  }
        /// <summary>
        /// Integer indicating what position the user finished in.
        /// </summary>
        public object place { get; set;  }
        /// <summary>
        /// String ordinal version of place, e.g. "3rd".
        /// </summary>
        public object place_ordinal { get; set;  }
        /// <summary>
        /// Integer amount of points earned by this entrant on the relevant leaderboard. Note that this is not the entrant's current score (unless the race is in progress), it is the score they had when they entered the race, not after.
        /// </summary>
        public int score { get; set;  }
        /// <summary>
        /// Integer amount of points gained/lost as a result of this race, or null (not zero!) if race is not recorded.
        /// </summary>
        public object score_change { get; set;  }
        /// <summary>
        /// A string containing a pithy comeback supplied by the user post-race, or null if they have no comment.
        /// </summary>
        public object comment { get; set;  }
        /// <summary>
        /// Boolean indicating if the user's stream is currently live. This is updated in real-time while a race is in progress, but once an entrant has finished, forfeited or been disqualified it will not be updated.
        /// </summary>
        public bool stream_live { get; set;  }
        /// <summary>
        /// Boolean indicating if a moderator overrode the streaming requirement for this race entrant, allowing them to ready up without their stream being online.
        /// </summary>
        public bool stream_override { get; set;  }
        /// <summary>
        /// Actions the user can do e.g. "add_comment", "change_comment"
        /// </summary>
        public List<string> actions { get; set;  }

    }

    public class RaceDetail
    {
        /// <summary>
        /// Integer indicating the data's version. This is incremented whenever a race changes.
        /// </summary>
        public int version { get; set;  }
        /// <summary>
        /// The race's unique name, based on the category and a randomly assigned slug.
        /// </summary>
        public string name { get; set;  }
        /// <summary>
        /// Unique category slug (part of the URL).
        /// </summary>
        public string slug { get; set;  }
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
        /// URL of the race WebSocket, used by the frontend for chat messages and real-time updates.
        /// </summary>
        public string websocket_url { get; set;  }
        /// <summary>
        /// URL of the WebSocket for category bots.
        /// </summary>
        public string websocket_bot_url { get; set;  }
        /// <summary>
        /// URL of the WebSocket for OAuth2-authenticated user connections. Used by third-party applications.
        /// </summary>
        public string websocket_oauth_url { get; set;  }
        /// <summary>
        /// An object giving brief information about the category. Contains:
        /// </summary>
        public Category category { get; set;  }
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
        /// The entrants list, given as an array. Ordered by race status, then by finish position (if applicable), then by score (if available), and finally by name. See below for a breakdown of entrant data blobs.
        /// </summary>
        public List<Entrant> entrants { get; set;  }
        /// <summary>
        /// Date/time when the race was first created (ISO 8601 date).
        /// </summary>
        public DateTime opened_at { get; set;  }
        /// <summary>
        /// The time allocated for the countdown, i.e. time lapse between the last entrant readying up and the race starting (ISO 8601 duration).
        /// </summary>
        public string start_delay { get; set;  }
        /// <summary>
        /// Date/time when the race started, or null if it hasn't started yet (ISO 8601 date).
        /// </summary>
        public DateTime started_at { get; set;  }
        /// <summary>
        /// Date/time when the race ended, or null if it hasn't finished yet (ISO 8601 date).
        /// </summary>
        public object ended_at { get; set;  }
        /// <summary>
        /// Date/time when the race was cancelled, or null if it hasn't been cancelled (ISO 8601 date).
        ///     Note: a race may be cancelled at any point before it's finished. If it was cancelled before the race started, started_at and ended_at will not be set. If it was cancelled after the race started, started_at will be set and ended_at will be equal to cancelled_at.
        /// </summary>
        public object cancelled_at { get; set;  }
        /// <summary>
        /// The maximum amount of time the race may be in progress for once it starts (ISO 8601 duration).
        /// </summary>
        public string time_limit { get; set;  }
        /// <summary>
        /// User data blob for the user who opened the race room. This user is always a race monitor.
        /// </summary>
        public User opened_by { get; set;  }
        /// <summary>
        /// Array of user data blobs for race monitors (in addition to the room opener) in this race.
        /// </summary>
        public List<User> monitors { get; set;  }
        /// <summary>
        /// Boolean indicating a race can be recorded once it's finished. A moderator may still opt to not record the race.
        /// </summary>
        public bool recordable { get; set;  }
        /// <summary>
        /// Boolean indicating if the race has been recorded by a moderator.
        /// </summary>
        public bool recorded { get; set;  }
        /// <summary>
        /// User data blob of the moderator who recorded this race.
        /// </summary>
        public object recorded_by { get; set;  }
        /// <summary>
        /// Boolean indicating if users may add a glib remark after they finish racing.
        /// </summary>
        public bool allow_comments { get; set;  }
        /// <summary>
        /// Boolean indicating if users may chat while the race is in progress (does not affect monitors or moderators).
        /// </summary>
        public bool allow_midrace_chat { get; set;  }
        /// <summary>
        /// Boolean indicating if users who have not entered the race may chat while the race is in progress (does not affect moderators).
        /// </summary>
        public bool allow_non_entrant_chat { get; set;  }
        /// <summary>
        /// Length of time where chat messages will only appear for race monitors (ISO 8601 duration).
        /// </summary>
        public string chat_message_delay { get; set;  }

    }


}
