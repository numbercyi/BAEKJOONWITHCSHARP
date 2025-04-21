//.\NewBaekjoonProject.ps1 -ProblemNumber "10828" -ProblemTitle "Stack"
using System;
using System.Linq;

namespace Baekjoon.Common
{
    public static class InputReader
    {
        public static int NextInt() => int.Parse(Console.ReadLine()!);
        public static long NextLong() => long.Parse(Console.ReadLine()!);
        public static string NextLine() => Console.ReadLine()!;

        public static int[] IntArray() =>
            Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        public static long[] LongArray() =>
            Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();

        public static string[] StringArray() =>
            Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    }
}
