using Codility.Training.CyclicRotation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.UnitTest.TCyclicRotation
{
    [TestClass]
    public class TCyclicRotation
    {
        [TestMethod]
        public void TestMethod1()
        {
            int moves = 3;
            int[] input = { 3, 8, 9, 7, 6 };
            int[] expected = { 9, 7, 6, 3, 8 };
            int[] result = CyclicRotation.Solution(input, moves);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int moves = 1;
            int[] input = { 0, 0, 0 };
            int[] expected = { 0, 0, 0 };
            int[] result = CyclicRotation.Solution(input, moves);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int moves = 4;
            int[] input = { 1, 2, 3, 4 };
            int[] expected = { 1, 2, 3, 4 };
            int[] result = CyclicRotation.Solution(input, moves);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
