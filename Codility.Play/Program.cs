using System;
using Codility.Training.Lesson4.Tasks;

namespace Codility.Play
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int result = PlayMissingInteger();
            Console.WriteLine(result);
        }

        private static int PlayMissingInteger()
        {
            int[] input = { 4, 5, 6, 2 };
            return MissingInteger.Solution(input);
        }
    }
}
