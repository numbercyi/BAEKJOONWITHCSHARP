using System;
using Baekjoon.Common;

namespace Baekjoon._1330_Comp
{
    public class CompSolver
    {
        public void Run()
        {
            String[] input = Console.ReadLine()!.Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);

            if(a>b)
            {
                Console.WriteLine(">");
            }
            else if (a < b)
            {
                Console.WriteLine("<");
            }
            else
            {
                Console.WriteLine("==");    
            }

        }
    }
}
