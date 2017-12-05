using System;

namespace Codility.Training.BinaryGap
{
    public static class BinaryGap
    {
        public static int Solution(int number)
        {
            int result = 0, temp = 0;
            string binary = Convert.ToString(number, 2);

            foreach (char b in binary)
            {
                if (b == '1')
                {
                    if (temp > result)
                    {
                        result = temp;
                    }

                    temp = 0;
                }
                else
                {
                    temp++;
                }
            }

            return result;
        }
    }
}
