using System.Collections.Generic;

namespace RacetimeGG
{
    

    public class CategoryDetail
    {
        /// <summary>
        /// The name of the category, e.g. "Super Mario 64".
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// An abbreviated name, e.g. "OoTR".
        /// </summary>
        public string short_name { get; set; }
        /// <summary>
        /// The unique slug that identifies this category.
        /// </summary>
        public string slug { get; set; }
        /// <summary>
        /// URL for the category's main page.
        /// </summary>
        public string url { get; set; }
        /// <summary>
        /// URL for the category data endpoint, i.e. this endpoint.
        /// </summary>
        public string data_url { get; set; }
        /// <summary>
        /// URL for the uploaded image to represent this category, or null if no image is set.
        /// </summary>
        public string image { get; set; }
        /// <summary>
        /// Category information blurb, as HTML. This is what appears in the sidebar on the main category page.
        /// </summary>
        public string info { get; set; }
        /// <summary>
        /// Boolean indicating if streaming is required in this category. Moderators may override this on a per-race basis.
        /// </summary>
        public bool streaming_required { get; set; }
        /// <summary>
        /// User data blob for the user who has ownership rights on the category.
        /// </summary>
        public User owner { get; set; }
        /// <summary>
        /// Array of user data blobs for users who can moderate the category.
        /// </summary>
        public List<object> moderators { get; set; }
        /// <summary>
        /// Array of races that are currently open or in progress, in summary form. Each race's information is the same as what's given in the all races endpoint, excluding the category field.
        /// </summary>
        public List<object> current_races { get; set; }

    }


}
