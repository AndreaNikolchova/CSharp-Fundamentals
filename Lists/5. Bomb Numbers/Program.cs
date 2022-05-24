using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string line = Console.ReadLine();
            List<int> listLine = line.Split().Select(int.Parse).ToList();
            List<int> leftSide = new List<int>();
            List<int> rightSide = new List<int>();
            int sum = LeftSide(leftSide, numbers, listLine)+ RightSide(rightSide, numbers, listLine);
            Console.WriteLine(sum);


        }
        static int LeftSide(List<int> leftSide, List<int> numbers, List<int> listLine )
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == listLine[0])
                {
                    break;

                }
                leftSide.Add(numbers[i]);
            }
            int number = listLine[1];
            if (leftSide.Count< listLine[1])
            {
                for (int i = listLine[1]; i >=0; i--)
                {
                    if ( listLine[1]-leftSide.Count> leftSide.Count)
                    {
                       number = listLine[1] - 1;
                    }
                }
            }
                for (int i = leftSide.Count-1; i >= number; i--)
                {
                    leftSide.RemoveAt(i);
                }
            int sum = 0;
            foreach (var i in leftSide)
            {
                sum += i;
            }
            return sum;



        }
        static int RightSide(List<int> rightSide, List<int> numbers, List<int> listLine)
        {
            for (int i = numbers.Count-1; i >= 0; i--)
            {
                if (numbers[i] == listLine[0])
                {
                    break;

                }
                rightSide.Add(numbers[i]);
            }
            int number = listLine[1];
            if (rightSide.Count < listLine[1])
            {
                for (int i = listLine[1]; i > 0; i--)
                {
                    if (number - rightSide.Count >= rightSide.Count)
                    {
                        number = number - 1;
                    }
                   
                }
            }
            for (int i = rightSide.Count-1; i >= number; i--)
            {
                rightSide.RemoveAt(i);
            }
            int sum = 0;
            foreach(var i in rightSide)
            {
                sum+=i;
            }
            return sum;
        }

    }
}
