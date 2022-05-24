using System;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultipleOfEvenAndOdds(number)); 
        }
        static int GetSumOfEvenDigits(int number)
        {
            string end = number.ToString();
            int sum = 0;
            for (int i = 0; i < end.Length; i++)
            {
                number = Math.Abs(number);
               int digit = number%10;
                number /= 10;
                if (digit%2==0)
                {
                    sum += digit;               
                }
            }
            return sum;

        }
        static int GetSumOfOddDigits(int number)
        {

            string end = number.ToString();
            int sum = 0;
            for (int i = 0; i < end.Length; i++)
            {
                number = Math.Abs(number);
                int digit = number % 10;
                number /= 10;
                if (digit % 2 != 0)
                {
                    sum += digit;
                }
            }
            return sum;
           

        }
        static int GetMultipleOfEvenAndOdds(int number)
        {
            return GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
        }
    }
}
