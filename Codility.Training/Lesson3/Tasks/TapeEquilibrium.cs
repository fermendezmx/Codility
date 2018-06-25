using System;
using System.Linq;

namespace Codility.Training.Lesson3.Tasks
{
    public static class TapeEquilibrium
    {
        public static int Solution(int[] A)
        {
            int N = A.Length;
            int splits = N - 1;
            int firstPart, secondPart, difference, result = 0;

            for (int P = 1; P <= splits; P++)
            {
                firstPart = A.Take(P).Sum();
                secondPart = A.Skip(P).Sum();
                difference = Math.Abs(firstPart - secondPart);

                if (difference < result || P == 1)
                {
                    result = difference;
                }
            }

            return result;
        }
    }
}
