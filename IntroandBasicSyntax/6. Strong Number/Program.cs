using System;

namespace _6._Strong_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int number2 = number;
            int digit = 0;
            int sum = 0;
            while (number2 > 0)
            {
                
                digit = number2 % 10;
                number2 = number2 / 10;
                if (digit == 0)
                {
                    digit++;
                }
                for (int i = digit-1; i >1; i--)
                {
                    digit *= i;
                    

                }
                sum += digit;

            }
            if (sum==number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            
            //string  number = Console.ReadLine();    
            //char[] array = number.ToCharArray();
            //char digit = ' ';
            //int fact = 0;
            //int digits = 0;

            //for (int i = number.Length - 1; i >= 0; i--)
            //{
            //     digit = array[i];
            //    string digitString = digit.ToString();  
            //    digits = int.Parse(digitString);

            //    for (int j = 1; j <= digit; j++)
            //    {

            //    }

            //}

        }
    }
}
