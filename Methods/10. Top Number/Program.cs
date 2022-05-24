using System;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
            Answer(n);
            
        }
        static void Answer(int end)
        {
            for (int i = 1; i <= end; i++)
            {
                if (First(i.ToString())&&Second(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool First(string n)
        {
            int number = int.Parse(n);
            int digit = 0;
            int sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                digit = number % 10;
                number = number / 10;
                sum += digit;
            }
            if(sum%8==0)
            {
                return true;
            }
            return false;
        }
        static bool Second(int n)
        { 
            int digit = 0;
            int count =0 ;
            for (int i = 1; i < n; i++)
            {
                digit = n % 10;
                n = n / 10;
                if (digit%2!=0)
                {
                    count++;
                }
            }
            if(count>=1)
            {
                return true;
            }
            return false;
        }
    }
}
