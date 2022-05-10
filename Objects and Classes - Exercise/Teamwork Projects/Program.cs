using System;
using System.Collections.Generic;
using System.Linq;

namespace _5
{
    class Team
    {
        public Team(string teamName, string creator)
        {
            this.Teamname = teamName;
            this.Creator = creator;
            this.Members = new List<string>();
        }
        public string Teamname { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }
        public void AddMemeber(string member)
        {
            this.Members.Add(member);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int countOfTeams = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            for (int i = 0; i < countOfTeams; i++)
            {
                string[] teamInfo = Console.ReadLine().Split("-");
                string creator = teamInfo[0];
                string teamName = teamInfo[1];
                if (teams.Any(teams => teams.Teamname == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teams.Any(teams => teams.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    Team team = new Team(teamName, creator);
                    teams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }
            string[] memberAndTeam = Console.ReadLine().Split("->");
            while (memberAndTeam[0] != "end of assignment")
            {
                string member = memberAndTeam[0];
                string teamName = memberAndTeam[1];
                Team searchTeam = teams.FirstOrDefault(s => s.Teamname == teamName);
                if (!teams.Any(teams => teams.Teamname == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (teams.Any(teams => teams.Members.Contains(member)) || teams.Any(teams => teams.Creator.Contains(member)))
                {
                    Console.WriteLine($"Member {member} cannot join team {teamName}!");
                }
                else
                {
                    searchTeam.Members.Add(member);
                }
                memberAndTeam = Console.ReadLine().Split("->");
            }
            var finalTeam = teams.Where(teams => teams.Members.Count > 0);
            var disband = teams.Where(teams => teams.Members.Count == 0);
            foreach (Team team in finalTeam.OrderByDescending(teams => teams.Members.Count).ThenBy(teams => teams.Teamname))
            {
                Console.WriteLine($"{team.Teamname}");
                Console.WriteLine($"- {team.Creator}");
                foreach (string member in team.Members.OrderBy(member => member))
                {
                    Console.WriteLine($"-- {member}");
                }

            }
            disband = disband.OrderBy(s => s.Teamname);
            Console.WriteLine($"Teams to disband:");
            foreach (var team in disband)
            {
                Console.WriteLine($"{team.Teamname}");
            }
        }
    }
}

