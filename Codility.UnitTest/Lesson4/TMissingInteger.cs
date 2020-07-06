using Codility.Training.Lesson4.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.UnitTest.Lesson4
{
    [TestClass]
    public class TMissingInteger
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] input = { 1, 3, 6, 4, 1, 2 };
            int expected = 5;
            int result = MissingInteger.Solution(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] input = { 4, 1, 3 };
            int expected = 2;
            int result = MissingInteger.Solution(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] input = { 1, 2, 3 };
            int expected = 4;
            int result = MissingInteger.Solution(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int[] input = { -1, -3 };
            int expected = 1;
            int result = MissingInteger.Solution(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            int[] input = { 4, 5, 6, 2 };
            int expected = 1;
            int result = MissingInteger.Solution(input);

            Assert.AreEqual(expected, result);
        }
    }
}
