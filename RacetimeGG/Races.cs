using System;
using System.Collections.Generic;

namespace RacetimeGG
{

    public class Category
    {
        /// <summary>
        /// The name of the category, e.g. "Super Mario 64".
        /// </summary>
        public string name { get; set;  }
        /// <summary>
        /// An abbreviated name, e.g. "OoTR".
        /// </summary>
        public string short_name { get; set;  }
        /// <summary>
        /// Unique category slug (part of the URL).
        /// </summary>
        public string slug { get; set;  }
        /// <summary>
        /// URL for the main category page.
        /// </summary>
        public string url { get; set;  }
        /// <summary>
        ///  URL for the category data endpoint, which you can use to obtain more detailed category information.
        /// </summary>
        public string data_url { get; set;  }
        /// <summary>
        /// URL for the uploaded image to represent this category, or null if no image is set.
        /// </summary>
        public string image { get; set;  }

    }
    public class Races
    {
        /// <summary>
        /// The list of races returned.
        /// </summary>
        public List<Race> races { get; set;  }

    }
}


