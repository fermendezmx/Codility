using Codility.Training.Lesson4.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.UnitTest.Lesson4
{
    [TestClass]
    public class TFrogRiverOne
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 5;
            int[] input = { 1, 3, 1, 4, 2, 3, 5, 4 };
            int expected = 6;
            int result = FrogRiverOne.Solution(x, input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int x = 5;
            int[] input = { 3 };
            int expected = -1;
            int result = FrogRiverOne.Solution(x, input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int x = 3;
            int[] input = { 1, 3, 1, 3, 2, 1 };
            int expected = 4;
            int result = FrogRiverOne.Solution(x, input);

            Assert.AreEqual(expected, result);
        }
    }
}
