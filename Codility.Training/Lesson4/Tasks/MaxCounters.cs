namespace Codility.Training.Lesson4.Tasks
{
    public static class MaxCounters
    {
        public static int[] Solution(int N, int[] A)
        {
            int counter;
            int max = 0;
            int m = A.Length;
            int[] counters = new int[N];

            // Run over every A[K] to look for possible operations 
            for (int k = 0; k < m; k++)
            {
                // If A[K] = N + 1 then operation K is max counter
                if (A[k] == N + 1)
                {
                    // Set every counter to the higher counter found until now
                    SetMaxCounter(max, counters);
                    continue;
                }

                // If A[K] = X, then operation K is increase(X)
                counter = ++counters[A[k] - 1];

                // If current counter is higher than 'max'
                if (counter > max)
                {
                    // Update 'max' and set the value of 'counter'
                    max = counter;
                }
            }

            return counters;
        }

        private static void SetMaxCounter(int max, int[] counters)
        {
            for (int i = 0; i < counters.Length; i++)
            {
                // Set every counter to the higher counter found until now
                counters[i] = max;
            }
        }
    }
}
