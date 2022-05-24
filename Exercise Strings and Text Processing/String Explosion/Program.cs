using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            List<char> input = line.ToCharArray().ToList();
            StringBuilder sb = new StringBuilder();
            int number = 0;
            List<char> output = line.ToCharArray().ToList();
            
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == '>')
                {
                  
                    number += input[i+1]-48;
                    if (input[i+2]== '>')
                    {
                        number -= 1;
                        output.RemoveAt(i + 1);
                    }
                    else
                    {
                        for (int j = i; j < i+number; j++)
                        {
                            number--;
                            output.RemoveAt(j);
                            
                        }
                    }
                    
                }
               
             
            }
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == '>')
                {
                    sb.Append(input[i]);
                    for (int j = i+1; j < input.Count; j++)
                    {
                        if (input[j] == '>')
                        {
                            sb.Append(input[j]);
                        }
                        else
                        {
                            number -= 1;
                        }
                    }
                    
                }
                else
                {
                    sb.Append(input[i]);
                }
            }

        }
    }
}
