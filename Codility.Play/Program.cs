using System;
using Codility.Training.Lesson4.Tasks;

namespace Codility.Play
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] result = PlayMaxCounters();
            Console.WriteLine(result);
        }

        private static int PlayMissingInteger()
        {
            int[] input = { 4, 5, 6, 2 };
            return MissingInteger.Solution(input);
        }

        private static int[] PlayMaxCounters()
        {
            int n = 5;
            int[] input = { 3, 4, 4, 6, 1, 4, 4 };
            return MaxCounters.Solution(n, input);
        }
    }
}
