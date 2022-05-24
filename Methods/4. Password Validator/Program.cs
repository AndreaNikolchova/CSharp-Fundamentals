using System;

namespace _4._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            char[] passwordArray = password.ToCharArray();
            GetAnswer(password, passwordArray);
        }
        static bool SeeFirstRule( char[] array)
        {
            if (array.Length < 6 || array.Length > 10)
            {
                return true;
            } 
            return false;
        }
        static bool SeeSecondRule(string s)
        {            
               
                foreach (char c in s)
                {
                    if (!Char.IsLetterOrDigit(c) && c != '_')
                    {
                    return false;
                    }
                        
                }
            return true;
             
        }
       
        static bool SeeThirdRule(string password)
        {
            int count = 0;
            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    count++;
                }
            }
            if (count < 2)
            {
                return true;
            }
            return false;

        }
        static void GetAnswer(string password, char[] array)
        {
            if (SeeFirstRule(array))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!SeeSecondRule(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (SeeThirdRule(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (!SeeFirstRule(array) && SeeSecondRule(password) && !SeeThirdRule(password))
            {
                Console.WriteLine("Password is valid");

            }
        }

    }
}
