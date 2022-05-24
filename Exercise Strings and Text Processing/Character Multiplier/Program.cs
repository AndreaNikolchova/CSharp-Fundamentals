using System;

namespace Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');
            char[] firstWord = words[0].ToCharArray();
            char[] secondWord = words[1].ToCharArray();
            int sum = 0;
            int number = 0;
            if (firstWord.Length<secondWord.Length)
            {
                for (int i = 0; i < firstWord.Length; i++)
                {
                    sum += (int)firstWord[i] * (int)secondWord[i];
                    number = i;
                }
                for (int i = number + 1; i < secondWord.Length; i++)
                {
                    sum += (int)secondWord[i];
                }
            }
            else
            {
                for (int i = 0; i < secondWord.Length; i++)
                {
                    sum += (int)firstWord[i] * (int)secondWord[i];
                    number = i;
                }
                for (int i = number + 1; i< firstWord.Length; i++)
                {
                    sum += (int)firstWord[i];
                }
            }
            Console.WriteLine(sum);
        }

    }
}
