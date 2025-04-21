using System;
using Baekjoon.Common;

namespace Baekjoon._10869_Operation
{
    public class OperationSolver
    {
        public void Run()
        {
            String[] input = Console.ReadLine()!.Split();

            int a = int.Parse(input[0]);   
            int b = int.Parse(input[1]);
            Console.WriteLine(a+b);
            Console.WriteLine(a-b);
            Console.WriteLine(a*b);
            Console.WriteLine(a/b);
            Console.WriteLine(a%b);

        } 
    }
}
