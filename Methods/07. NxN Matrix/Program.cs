using System;

namespace _07._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NxNColona(NxNImput());
            
        }
        static int NxNImput()
        {
            int n = int.Parse(Console.ReadLine());
            return n;

        }
        static void NxNLine(int end)
        {
            for (int i = 1; i <=end ; i++)
            {
                Console.Write($"{end} ");
            }

        }
        static void NxNColona(int end)
        {
            for (int i = 1; i <= end; i++)
            {
                NxNLine(end);
                Console.WriteLine();
            }
        }
    }
}
