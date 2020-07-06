namespace Codility.Training.Lesson4.Tasks
{
    public static class FrogRiverOne
    {
        public static int Solution(int X, int[] A)
        {
            int result = -1;
            int counter = 0;
            int n = A.Length;
            int[] positions = new int[X + 1];

            for (int i = 0; i < n; i++)
            {
                if (positions[A[i]] == 0)
                {
                    counter++;
                }

                positions[A[i]]++;

                if (counter == X)
                {
                    result = i;
                    break;
                }
            }

            return result;
        }
    }
}
