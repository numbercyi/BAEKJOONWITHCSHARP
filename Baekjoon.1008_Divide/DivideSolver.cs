using System;
using Baekjoon.Common;

namespace Baekjoon._1008_Divide
{
    public class DivideSolver
    {
        public void Run()
        {
           String[] input = Console.ReadLine()!.Split();
            double a = double.Parse(input[0]);
            double b = double.Parse(input[1]);
            Console.WriteLine(a/b);
        }
    }
}
