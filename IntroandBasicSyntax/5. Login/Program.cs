using System;

namespace _5._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            
            char[] array = username.ToCharArray();
            string password ="";
            for (int i = username.Length-1 ; i >= 0; i--)
            {
                char letter = array[i];
                 password +=letter.ToString();

            }
            string pasword1=Console.ReadLine();
            int count = 0;
            while (password!=pasword1)
            {
                count++;
                if (count == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");
                pasword1 = Console.ReadLine();
                
                

            }
            
               Console.WriteLine($"User {username} logged in.");
           
            
            
        }
    }
}
