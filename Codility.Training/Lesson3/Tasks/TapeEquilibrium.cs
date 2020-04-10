using System;

namespace Codility.Training.Lesson3.Tasks
{
    public static class TapeEquilibrium
    {
        public static int Solution(int[] A)
        {
            int N = A.Length;
            int firstPart = default,
                secondPart = default,
                difference, result = 0;

            for (int P = 0; P < N; P++)
            {
                secondPart += A[P];
            }

            for (int P = 0; P < N - 1; P++)
            {
                firstPart += A[P];
                secondPart -= A[P];

                difference = Math.Abs(firstPart - secondPart);

                if (difference < result || P == 0)
                {
                    result = difference;
                }
            }

            return result;
        }
    }
}
