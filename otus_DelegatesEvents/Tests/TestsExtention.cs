using otus_DelegatesEvents.Extensions;
using otus_DelegatesEvents.Tests.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otus_DelegatesEvents.ConsoleWriter
{
    internal class TestsExtention
    {
        public string TheBestTeam() {
            List<Team> teams = new List<Team>() {
            new Team() { TeamName = "Team A", TeamPoints = 33},
            new Team() { TeamName = "Team B", TeamPoints = 11},
            new Team() { TeamName = "Team C", TeamPoints = 0},
            new Team() { TeamName = "Team D", TeamPoints = 99}};

            var bestTeam = teams.GetMax(t => t.TeamPoints);
            return $"The best team in season: {bestTeam.TeamName} with {bestTeam.TeamPoints} points";
        }

        public string TheHighestMountain() {
            List<Mountain> mountains = new List<Mountain>() {
            new Mountain(){ MountainName = "Mount Everest", MountainHeight = 8.848  },
            new Mountain(){ MountainName = "Tirich Mir", MountainHeight = 7.708 },
            new Mountain(){ MountainName = "Mount Gongga", MountainHeight = 7.556 },
            new Mountain(){ MountainName = "Gyala Peri", MountainHeight =   7.294 }};

            var highestMountain = mountains.GetMax(m => (float)m.MountainHeight);
            return $"The Highest mountain: {highestMountain.MountainName} with {highestMountain.MountainHeight} km.";
        }

    }
}
