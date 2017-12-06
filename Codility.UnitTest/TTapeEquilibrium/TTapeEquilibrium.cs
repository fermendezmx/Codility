using Codility.Training.TapeEquilibrium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.UnitTest.TTapeEquilibrium
{
    [TestClass]
    public class TTapeEquilibrium
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] input = { 3, 1, 2, 4, 3 };
            int expected = 1;
            int result = TapeEquilibrium.Solution(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] input = { 5, 9, 10, 6, 3, 1, 8, 2, 7 };
            int expected = 3;
            int result = TapeEquilibrium.Solution(input);

            Assert.AreEqual(expected, result);
        }
    }
}
