namespace Codility.Training.Lesson4.Tasks
{
    public static class PermCheck
    {
        public static int Solution(int[] A)
        {
            int result = 0;
            int counter = 0;
            int n = A.Length;
            int[] positions = new int[n + 1];

            for (int i = 0; i < n; i++)
            {
                // Validate that A[i] is in range of 1 to 'n'
                if (A[i] > n)
                {
                    // If it is out of range is not a permutation
                    break;
                }

                // Indicates that we found the element on A[i]
                positions[A[i]]++;

                // The element should be just once
                if (positions[A[i]] == 1)
                {
                    // So we count every time an element is found
                    counter++;
                    continue;
                }

                // The element is not only once so we quit
                break;
            }

            // If all the elements were found
            if (counter == n)
            {
                // Then is a permutation
                result = 1;
            }

            return result;
        }
    }
}
