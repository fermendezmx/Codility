namespace Codility.Training.Lesson2.Tasks
{
    public static class CyclicRotation
    {
        public static int[] Solution(int[] array, int moves)
        {
            int tempA = 0, tempB = 0;
            int total = array.Length;

            for (int i = 0; i < moves; i++)
            {
                for (int j = 0; j < total; j++)
                {
                    if (j == 0)
                    {
                        tempA = array[j];
                        array[j] = array[total - 1];
                    }
                    else
                    {
                        tempB = array[j];
                        array[j] = tempA;
                        tempA = tempB;
                    }
                }
            }

            return array;
        }
    }
}
