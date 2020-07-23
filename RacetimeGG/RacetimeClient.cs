using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace RacetimeGG
{
    public class RacetimeClient
    {
        /// <summary>
        /// The main website API url
        /// </summary>
        public string SiteUrl = "https://racetime.gg/";

        /// <summary>
        /// Returns a list of all open and ongoing races.
        /// </summary>
        /// <returns></returns>
        public async System.Threading.Tasks.Task<Races> GetAllRacesAsync()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(SiteUrl);
                var result = await client.GetAsync("races/data");
                result.EnsureSuccessStatusCode();
                string resultContentString = await result.Content.ReadAsStringAsync();
                Races resultContent = JsonConvert.DeserializeObject<Races>(resultContentString);
                return resultContent;
            }
        }

        /// <summary>
        /// This endpoint includes all the basic information about the category shown on the webpage, except for past races. Current races are given in a summarised format, full race information must be retrieved individually.
        /// </summary>
        /// <param name="Category">The Category Slug</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task<CategoryDetail> GetCategoryDetailAsync(string Category)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(SiteUrl);
                var result = await client.GetAsync(Category + "/data");
                result.EnsureSuccessStatusCode();
                string resultContentString = await result.Content.ReadAsStringAsync();
                CategoryDetail resultContent = JsonConvert.DeserializeObject<CategoryDetail>(resultContentString);
                return resultContent;
            }
        }

        /// <summary>
        /// Returns a list of all completed (finished and cancelled) races in a category. This list is paginated, and sorted by each race's completion time (the ended_at field), most recent first. 10 races are returned per page.
        /// </summary>
        /// <param name="Category">The Category Slug.</param>
        /// <param name="ShowEntrants">True to include entrant data for each race returned.</param>
        /// <param name="Page">The page to get paginated data from.</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task<PastRaces> GetPastCategoryRacesAsync(string Category, bool ShowEntrants = false, int Page = 0)
        {
            string entrants = string.Empty;
            string pagenum = string.Empty;
            if (ShowEntrants == true)
            {
                entrants = "?show_entrants=true";
            }
            if(Page != 0)
            {
                if(entrants == string.Empty)
                {
                    pagenum = "?page=" + Page.ToString();
                }
                else
                {
                    pagenum = "&page=" + Page.ToString();
                }
            }
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(SiteUrl);
                var result = await client.GetAsync(Category + "/races/data" + entrants + pagenum);
                result.EnsureSuccessStatusCode();
                string resultContentString = await result.Content.ReadAsStringAsync();
                PastRaces resultContent = JsonConvert.DeserializeObject<PastRaces>(resultContentString);
                return resultContent;
            }
        }

        /// <summary>
        /// Provides category leaderboard data.
        /// </summary>
        /// <param name="Category">The Category Slug.</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task<CategoryLeaderboards> GetCategoryLeaderboardsAsync(string Category)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(SiteUrl);
                var result = await client.GetAsync(Category + "/leaderboards/data");
                result.EnsureSuccessStatusCode();
                string resultContentString = await result.Content.ReadAsStringAsync();
                CategoryLeaderboards resultContent = JsonConvert.DeserializeObject<CategoryLeaderboards>(resultContentString);
                return resultContent;
            }
        }

        /// <summary>
        /// This endpoint covers everything you might want to know about a race. All the data shown on the race page, except for chat messages, is provided. A full breakdown of entrants is also here, which is sorted by race status and finish position, as appropriate.
        /// </summary>
        /// <param name="Category">The Category Slug.</param>
        /// <param name="Race">The race room identifier</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task<RaceDetail> GetRaceDetailAsync(string Category, string Race)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(SiteUrl);
                var result = await client.GetAsync(Category + "/" + Race + "/data");
                result.EnsureSuccessStatusCode();
                string resultContentString = await result.Content.ReadAsStringAsync();
                RaceDetail resultContent = JsonConvert.DeserializeObject<RaceDetail>(resultContentString);
                return resultContent;
            }
        }

        /// <summary>
        /// Returns a list of all finished (but not cancelled) races that a user has entered. This list is paginated, and sorted by each race's completion time (the ended_at field), most recent first. 10 races are returned per page.
        /// </summary>
        /// <param name="User">The users Id</param>
        /// <param name="ShowEntrants">True to include entrant data for each race returned.</param>
        /// <param name="Page">The page to get paginated data from.</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task<PastRaces> GetPastUserRacesAsync(string User, bool ShowEntrants = false, int Page = 0)
        {
            string entrants = string.Empty;
            string pagenum = string.Empty;
            if (ShowEntrants == true)
            {
                entrants = "?show_entrants=true";
            }
            if (Page != 0)
            {
                if (entrants == string.Empty)
                {
                    pagenum = "?page=" + Page.ToString();
                }
                else
                {
                    pagenum = "&page=" + Page.ToString();
                }
            }
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(SiteUrl);
                var result = await client.GetAsync("user/" + User + "/races/data" + entrants + pagenum);
                result.EnsureSuccessStatusCode();
                string resultContentString = await result.Content.ReadAsStringAsync();
                PastRaces resultContent = JsonConvert.DeserializeObject<PastRaces>(resultContentString);
                return resultContent;
            }
        }
    }

}
