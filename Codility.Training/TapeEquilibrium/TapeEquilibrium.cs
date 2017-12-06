namespace Codility.Training.TapeEquilibrium
{
    public static class TapeEquilibrium
    {
        public static int Solution(int[] A)
        {
            int N = A.Length;
            int splits = N - 1;

            int result = 0;

            for (int P = 1; P <= splits; P++)
            {
                int firstPart = 0, secondPart = 0;

                for (int i = 0; i < N; i++)
                {
                    if(i < P)
                    {
                        firstPart += A[i];
                    }
                    else
                    {
                        secondPart += A[i];
                    }
                }

                int difference = firstPart - secondPart;
                
                if(difference < 0)
                {
                    difference *= -1;
                }

                if(difference < result || P == 1)
                {
                    result = difference;
                }
            }

            return result;
        }
    }
}
