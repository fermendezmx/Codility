using Codility.Training.Lesson1.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.UnitTest.Lesson1
{
    [TestClass]
    public class TBinaryGap
    {
        [TestMethod]
        public void TestMethod1()
        {
            int input = 9;
            int expected = 2;
            int result = BinaryGap.Solution(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int input = 529;
            int expected = 4;
            int result = BinaryGap.Solution(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int input = 20;
            int expected = 1;
            int result = BinaryGap.Solution(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int input = 1041;
            int expected = 5;
            int result = BinaryGap.Solution(input);

            Assert.AreEqual(expected, result);
        }
    }
}
