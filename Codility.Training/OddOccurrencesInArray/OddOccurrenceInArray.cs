using System.Collections.Generic;
using System.Linq;

namespace Codility.Training.OddOccurrencesInArray
{
    public static class OddOccurrenceInArray
    {
        public static int Solution(int[] array)
        {
            List<int> result = new List<int>();

            foreach (int a in array)
            {
                if (result.Contains(a))
                {
                    result.Remove(a);
                }
                else
                {
                    result.Add(a);
                }
            }

            return result.FirstOrDefault();
        }
    }
}
