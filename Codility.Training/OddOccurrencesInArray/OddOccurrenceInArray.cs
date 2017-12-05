using System.Linq;

namespace Codility.Training.OddOccurrencesInArray
{
    public static class OddOccurrenceInArray
    {
        public static int Solution(int[] array)
        {
            int result = 0;
            array = array.OrderBy(x => x).ToArray();

            for (int i = 0; i < array.Length - 1;)
            {
                if (array[i] == array[i + 1])
                {
                    i = i + 2;
                }
                else
                {
                    result = array[i];
                    break;
                }
            }

            return result > 0 ? result : array[array.Length - 1];
        }

        #region 25% in performace

        //public static int Solution(int[] array)
        //{
        //    List<int> result = new List<int>();

        //    foreach (int a in array)
        //    {
        //        if (result.Contains(a))
        //        {
        //            result.Remove(a);
        //        }
        //        else
        //        {
        //            result.Add(a);
        //        }
        //    }

        //    return result.FirstOrDefault();
        //}

        #endregion
    }
}
