using System;
using System.Linq;

namespace Codility.Training.TapeEquilibrium
{
    public static class TapeEquilibrium
    {
        public static int Solution(int[] A)
        {
            int N = A.Length;
            int splits = N - 1;
            int[] first, second;
            int firstPart, secondPart, difference, result = 0;

            for (int P = 1; P <= splits; P++)
            {
                first = A.Take(P).ToArray();
                second = A.Skip(P).ToArray();

                firstPart = first.Sum();
                secondPart = second.Sum();
                difference = Math.Abs(firstPart - secondPart);
                
                if(difference < result || P == 1)
                {
                    result = difference;
                }
            }

            return result;
        }

        #region 0% in performance

        //public static int Solution(int[] A)
        //{
        //    int N = A.Length;
        //    int splits = N - 1;
        //    int result = 0;

        //    for (int P = 1; P <= splits; P++)
        //    {
        //        int firstPart = 0, secondPart = 0;

        //        for (int i = 0; i < N; i++)
        //        {
        //            if(i < P)
        //            {
        //                firstPart += A[i];
        //            }
        //            else
        //            {
        //                secondPart += A[i];
        //            }
        //        }

        //        int difference = firstPart - secondPart;

        //        if(difference < 0)
        //        {
        //            difference *= -1;
        //        }

        //        if(difference < result || P == 1)
        //        {
        //            result = difference;
        //        }
        //    }

        //    return result;
        //}

        #endregion
    }
}
