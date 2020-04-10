using System;

namespace Codility.Training.Lesson3.Tasks
{
    public static class PermMissingElem
    {
        public static int Solution(int[] A)
        {
            int N = A.Length;
            int result = N + 1;

            Array.Sort(A);

            for (int i = 0; i < N; i++)
            {
                if (A[i] != i + 1)
                {
                    result = i + 1;
                    break;
                }
            }

            return result;
        }
    }
}
