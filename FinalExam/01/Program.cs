using System;
using System.Text;

namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string imput = Console.ReadLine();
           StringBuilder spell = new StringBuilder();
           string line  = Console.ReadLine();
            spell.Append(imput);
            while (line!= "Abracadabra")
            {
                string[] command = line.Split(' ');
                switch (command[0])
                {
                    case "Abjuration":
                       string spellUpper = spell.ToString().ToUpper();
                        spell.Clear();
                        spell.Append(spellUpper);
                        Console.WriteLine(spell.ToString());
                        break;
                    case "Necromancy":
                        string spellLower = spell.ToString().ToLower();
                        spell.Clear();
                        spell.Append(spellLower);
                        Console.WriteLine(spell.ToString());
                        break;
                    case "Illusion":
                        if (int.Parse(command[1]) >= 0 && int.Parse(command[1]) <= spell.Length - 1)
                        {
                            spell[int.Parse(command[1])] = char.Parse(command[2]);
                            Console.WriteLine("Done!");
                        }
                        else
                        {
                            Console.WriteLine("The spell was too weak.");
                        }
                        break;
                    case "Divination":
                        string oldSpell = spell.ToString();
                        spell.Replace(command[1],command[2]);
                        if (oldSpell!= spell.ToString())
                        {
                            Console.WriteLine(spell.ToString());
                        }
                        break;
                    case "Alteration":
                        string replace = spell.ToString();
                        if (replace.Contains(command[1]))
                        {
                            spell.Replace(command[1],string.Empty);
                            Console.WriteLine(spell.ToString());
                        }
                        break;

                    default:
                        Console.WriteLine("The spell did not work!");
                        break;
                }
                line = Console.ReadLine();
            }
            
        }
    }
}
