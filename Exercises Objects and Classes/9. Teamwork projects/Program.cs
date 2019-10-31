using System;
using System.Collections.Generic;
using System.Linq;

namespace _9._Teamwork_projects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            int numberOfTeams = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfTeams; i++)
            {
                string[] currentTeam = Console.ReadLine().Split('-');
                if(teams.Exists(x => x.NameOfTeam == currentTeam[1]))
                {
                    Console.WriteLine($"Team {currentTeam[1]} was already created!");
                }
                else if(teams.Exists(x => x.CreatorName == currentTeam[0]))
                {
                    Console.WriteLine($"{currentTeam[0]} cannot create another team!");
                }
                else
                {
                    teams.Add(new Team(currentTeam[1], currentTeam[0]));
                    Console.WriteLine($"Team {currentTeam[1]} has been created by {currentTeam[0]}!");
                }
            }
            string currentRequest = Console.ReadLine();
            while (currentRequest != "end of assignment")
            {
                string[] currentRequestArgs = currentRequest.Split("->".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
                string currentUserRequesting = currentRequestArgs[0];
                string currentTeamRequested = currentRequestArgs[1];
                if(teams.Exists(x => x.NameOfTeam == currentTeamRequested) == false)
                {
                    Console.WriteLine($"Team {currentTeamRequested} does not exist!");
                }
                else if(teams.Exists(x => x.CreatorName == currentUserRequesting ||
                                     x.Members.Exists(y => y == currentUserRequesting)))
                {
                    Console.WriteLine($"Member {currentUserRequesting} cannot join team {currentTeamRequested}!");
                }
                else
                {
                    int pos = teams.FindIndex(x => x.NameOfTeam == currentTeamRequested);
                    teams[pos].Members.Add(currentUserRequesting);
                }
                currentRequest = Console.ReadLine();
            }
            foreach (var team in teams.OrderByDescending(x => x.Members.Count).ThenBy(t => t.NameOfTeam).Where(y => y.Members.Count !=0 ))
            {
                Console.WriteLine(team.NameOfTeam);
                Console.WriteLine($"- {team.CreatorName}");
                foreach (var member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (var team in teams.OrderBy(x => x.NameOfTeam).Where(y => y.Members.Count == 0))
            {
                Console.WriteLine(team.NameOfTeam);
            }
        }
    }
    class Team
    {
        public string NameOfTeam;
        public List<string> Members;
        public string CreatorName;
        public Team(string nameOfTeam , string creatorName)
        {
            NameOfTeam = nameOfTeam;
            Members = new List<string>();
            CreatorName = creatorName;
        }
    }
}
