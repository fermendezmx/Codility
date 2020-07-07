namespace Codility.Training.Lesson4.Tasks
{
    public static class MaxCounters
    {
        public static int[] Solution(int N, int[] A)
        {
            int counter;
            int max = 0;
            int start = 0;
            int m = A.Length;
            int[] counters = new int[N];

            // Run over every A[K] to look for possible operations 
            for (int k = 0; k < m; k++)
            {
                // If A[K] = N + 1 then operation K is max counter
                if (A[k] == N + 1)
                {
                    // Set a new start for every element
                    start = max;
                    continue;
                }

                // If the current counter is behind
                if (counters[A[k] - 1] < start)
                {
                    // Update the counter to the latest 'max' found
                    counters[A[k] - 1] = start;
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

            // Look for those counters that are behind the last 'max' value
            for (int i = 0; i < counters.Length; i++)
            {
                if (counters[i] < start)
                {
                    // Set the counter to the higher counter found until now
                    counters[i] = start;
                }
            }

            return counters;
        }
    }
}
