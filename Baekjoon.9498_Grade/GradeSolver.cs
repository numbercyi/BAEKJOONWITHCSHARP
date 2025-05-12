using System;
using Baekjoon.Common;

namespace Baekjoon._9498_Grade
{
    public class GradeSolver
    {
        public void Run()
        {
            String[] input = Console.ReadLine()!.Split();
            int a = int.Parse(input[0]);

            switch (a)
            {
                case >= 90:
                    Console.WriteLine("A");
                    break;
                case >= 80:
                    Console.WriteLine("B");
                    break;
                case >= 70:
                    Console.WriteLine("C");
                    break;
                case >= 60:
                    Console.WriteLine("D");
                    break;
                default:
                    Console.WriteLine("F");
                    break;
            }
        }
    }
}
