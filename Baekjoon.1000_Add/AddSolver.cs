using System;
using Baekjoon.Common;

namespace Baekjoon._1000_Add
{
    public class AddSolver
    {
        public void Run()
        {
            string[] input = Console.ReadLine().Split();

            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);

            Console.WriteLine(a+b);

        }
    }
}
