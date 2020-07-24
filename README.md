# RacetimeGG-Sharp 
##### RacetimeGG API Connector in C#
Not really a perfect connection to the API. 
You can still do set vars on properties even though they should be get only.
Nor does it have JsonProperties properly declaring functions in the correct casing.

# Getting the package
As this was a side project you must build the project yourself to get a usable DLL

Clone the repo and run build
```
git clone https://github.com/Killklli/RacetimeGG-Sharp.git
cd RacetimeGG-Sharp
dotnet build -c release
```
Then from your project set a reference to the external DLL generated by that build

# Requirements
`Newtonsoft Json`

# Example usage
```cs
using RacetimeGG;
using System;
using System.Threading.Tasks;

namespace RacetimeExample
{
    public static async Task Main(string[] args)
    {
        // Set the variables for usage later
        string Category = "ootr";
        string Race = "temporary-race-1234";
        string User = "5JlzyB7qeOoV4GED";
        bool ShowEntrants = true;
        int Page = 1;

        // Create the client
        RacetimeClient RaceClient = new RacetimeClient
        {
            // Set the site URL if you are using a non standard site (Defaults to racetime.gg)
            SiteUrl = "https://racetime.gg"
        };


        // Getting all the races available
        Races RaceList = await RaceClient.GetAllRacesAsync();
        // Print the info of the first race
        Console.WriteLine(RaceList.races[0].name);


        // Getting category details
        CategoryDetail CatDetail = await RaceClient.GetCategoryDetailAsync(Category);
        // Print the category name
        Console.WriteLine(CatDetail.name);


        // Gets the category leaderboards
        CategoryLeaderboards Leaderboard = await RaceClient.GetCategoryLeaderboardsAsync(Category);
        // Prints the goal of the first leaderboard
        Console.WriteLine(Leaderboard.leaderboards[0].goal);


        // Gets the list of all completed races in a category including their entrants and only on the first page.
        PastRaces Past = await RaceClient.GetPastCategoryRacesAsync(Category, ShowEntrants, Page);
        // Prints the number of pages returned
        Console.WriteLine(Past.num_pages);


        // Gets the list of races the user has been in
        PastRaces UsersRaces = await RaceClient.GetPastUserRacesAsync(User, ShowEntrants, Page);
        // Prints the first race name the person was in
        Console.WriteLine(UsersRaces.races[0].name);


        // Gets the info about a race that has occured using the race ID
        RaceDetail RaceInfo = await RaceClient.GetRaceDetailAsync(Category, Race);
        // Prints the race name
        Console.WriteLine(RaceInfo.name);
    }
}
```