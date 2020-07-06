using System.Linq;

namespace Codility.Training.Lesson4.Tasks
{
    public static class MissingInteger
    {
        public static int Solution(int[] A)
        {
            int result = 1;
            int n = A.Length;
            int higher = A.Max();
            int[] positives = new int[higher + 2];

            // First: We look for every number in the array
            for (int i = 0; i < n; i++)
            {
                // Ignore all negatives and zero
                if (A[i] <= 0)
                {
                    continue;
                }

                // Count the occurence of A[i]
                positives[A[i]]++;
            }

            // Last: We look for the fist positive number that doesn't occur in A
            for (int j = 1; j < positives.Length; j++)
            {
                // If positives[j] not occur in A
                if (positives[j] == 0)
                {
                    // Then 'j' is the smallest positive integer that we are looking for 
                    result = j;
                    break;
                }
            }

            return result;
        }
    }
}
