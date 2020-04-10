using System;

namespace Codility.Training.Lesson3.Tasks
{
    public static class FrogJmp
    {
        public static int Solution(int X, int Y, int D)
        {
            return (int)Math.Ceiling((double)(Y - X) / D);
        }
    }
}
