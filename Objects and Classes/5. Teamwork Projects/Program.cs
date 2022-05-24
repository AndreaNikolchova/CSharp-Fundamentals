using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Teamwork_Projects
{
    internal class Program
    {
        

        class Teams
        {
            public string Name { get; set; }
            public string NameTeam { get; set; }
            public List<string> Members { get; set; }
            public Teams(string name,string nameTeam)
            {
                this.Name = name;
                this.NameTeam = nameTeam;
                Members = new List<string>();
            }

        }
        static bool CheckIfTeamIsCreated(List<Teams> list, List<string> input)
        {
            foreach (Teams team in list)
            {
                if (input.Contains(team.NameTeam))
                {
                    return true;
                }
            }
            return false;

        }
        static bool IfUserCreated(List<Teams> list, List<string> input)
        {
            foreach (Teams team in list)
            {
                if (input.Contains(team.Name))
                {
                    return true;
                }
            }
            return false;

        }
        static bool CheckIfTeamExists(List<Teams> teams,List<string> input)
        {
            foreach (Teams team in teams)
            {
                if (input.Contains(team.NameTeam))
                {
                    return true;
                }
            }
            return false;
        }
        static bool IfUserIsCheating(List<Teams> teams, List<string> input, List<string> members)
        {
            foreach (Teams team in teams)
            {
                if (input.Contains(team.Name))
                {
                    return true;
                }
            }
            return false;
        }
        static bool IfUserIsInAnotherTeam(List<Teams> teams, List<string> input)
        {
            return teams.Any(x=>x.Members.Contains(input[0]));
        }



        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<Teams> teams = new List<Teams>();
            List<string> members = new List<string>();
            for (int i = 0; i < number; i++)
            {
                List<string> listInput = Console.ReadLine().Split("-").ToList();
                if (!CheckIfTeamIsCreated(teams, listInput)&&!IfUserCreated(teams, listInput))
                {
                    teams.Add(new Teams(listInput[0],listInput[1]));
                    Console.WriteLine($"Team {listInput[1]} has been created by {listInput[0]}!");
                }
                else if (CheckIfTeamIsCreated(teams,listInput))
                {
                    Console.WriteLine($"Team {listInput[1]} was already created!");
                }
                else if (IfUserCreated(teams, listInput))
                {
                    Console.WriteLine($"{listInput[0]} cannot create another team!");
                }
            }
            
            string input = Console.ReadLine();
            while (input != "end of assignment")
            {
                List<string> listInputTeams = input.Split("->").ToList();
                if (CheckIfTeamExists(teams, listInputTeams)&&!IfUserIsCheating(teams, listInputTeams, members)&&!IfUserIsInAnotherTeam(teams,listInputTeams))
                {
                    int index = teams.FindIndex(x => x.NameTeam == listInputTeams[1]);
                    teams[index].Members.Add(listInputTeams[0]);
                    
                }
                else if (!CheckIfTeamExists(teams,listInputTeams))
                {
                    Console.WriteLine($"Team {listInputTeams[1]} does not exist!");
                }
                else if (IfUserIsCheating(teams,listInputTeams,members) || IfUserIsInAnotherTeam(teams, listInputTeams))
                {
                    Console.WriteLine($"Member {listInputTeams[0]} cannot join team {listInputTeams[1]}!");
                }
                input = Console.ReadLine();
            }
            teams.OrderBy(x=>x.NameTeam);
           
            foreach(Teams team in teams)
            {
                if (team.Members.Count>0)
                {
                    Console.WriteLine(team.NameTeam);
                    Console.WriteLine($"- {team.Name}");
                    foreach(string member in team.Members)
                    {
                        Console.WriteLine($"-- {member}");
                    }
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach(Teams team in teams)
            {
                if (team.Members.Count == 0)
                {
                    Console.WriteLine(team.NameTeam);
                } 
            }
        }
    }
}
