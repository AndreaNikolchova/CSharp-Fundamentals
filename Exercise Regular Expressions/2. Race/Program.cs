using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _2._Race
{
    internal class Program
    {
        class Players
        {
            public string Name { get; set; }
            public int  Score { get; set; }
            public Players(string name,int score)
            {
                this.Name = name;
                this.Score = score;
            }

        }

        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(", ").ToList();
            List<Players> players = new List<Players>();
            string line = Console.ReadLine();
            string patternName = @"[A-Za-z]+";
            string patternScore = @"[0-9]+";
            while (line != "end of race")
            {
                MatchCollection nameMatch = Regex.Matches(line, patternName);
                StringBuilder sb = new StringBuilder();
                foreach(Match match in nameMatch)
                {
                    sb.Append(match.Value);
                }
                MatchCollection scoreMatch = Regex.Matches(line, patternScore);
                int sum = 0;
                StringBuilder stringBuilder = new StringBuilder();
                foreach (Match m in scoreMatch)
                {
                   stringBuilder.Append(m.Value);
                }
                char[] scores = stringBuilder.ToString().ToCharArray();
                foreach(var c in scores)
                {
                    sum += c - 48;
                }
                foreach (var name in list)
                {
                    if (sb.ToString() == name)
                    {
                        if (players.Any(x=>x.Name.Contains(sb.ToString())))
                        {
                            int index = players.FindIndex(x=>x.Name.Equals(sb.ToString()));
                            players[index].Score+=sum;
                            break;
                        }
                        else 
                        {

                        players.Add(new Players(name, sum));
                        break;
                        }
                    }
                }
                line = Console.ReadLine();
            }
            players = players.OrderByDescending(p => p.Score).ToList();
            Console.WriteLine($"1st place: {players[0].Name}");
            Console.WriteLine($"2nd place: {players[1].Name}");
            Console.WriteLine($"3rd place: {players[2].Name}");

        }
    }
}
