using otus_DelegatesEvents.Extentions;
using otus_DelegatesEvents.Tests;
using otus_DelegatesEvents.Tests.Models;


namespace otus_DelegatesEvents.ConsoleWriter
{
    internal class StartExtention
    {

        public event EventHandler<GetMaxEventArgs> MaxElementFound;
        public void TheBestTeam() {
            List<Team> teams = new List<Team>() {
            new Team() { TeamName = "Team A", TeamPoints = 33},
            new Team() { TeamName = "Team B", TeamPoints = 11},
            new Team() { TeamName = "Team C", TeamPoints = 0},
            new Team() { TeamName = "Team D", TeamPoints = 99}};

            var bestTeam = teams.GetMax(t => t.TeamPoints);
            OnMaxElementFound($"event: The best team in season: {bestTeam.TeamName} with {bestTeam.TeamPoints} points");

        }

        public void TheHighestMountain() {
            List<Mountain> mountains = new List<Mountain>() {
            new Mountain(){ MountainName = "Mount Everest", MountainHeight = 8.848  },
            new Mountain(){ MountainName = "Tirich Mir", MountainHeight = 7.708 },
            new Mountain(){ MountainName = "Mount Gongga", MountainHeight = 7.556 },
            new Mountain(){ MountainName = "Gyala Peri", MountainHeight =   7.294 }};

            var highestMountain = mountains.GetMax(m => (float)m.MountainHeight);
            OnMaxElementFound($"event: The Highest mountain: {highestMountain.MountainName} with {highestMountain.MountainHeight} km.");
        }

        public void OnMaxElementFound(string message)
        {
            MaxElementFound(this, new GetMaxEventArgs(message));
        }

    }
}
