using Codility.Training.Lesson3.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.UnitTest.Lesson3
{
    [TestClass]
    public class TFrogJmp
    {
        [TestMethod]
        public void TestMethod1()
        {
            int X = 10;
            int Y = 85;
            int D = 30;
            int expected = 3;
            int result = FrogJmp.Solution(X, Y, D);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int X = 2;
            int Y = 245;
            int D = 8;
            int expected = 31;
            int result = FrogJmp.Solution(X, Y, D);

            Assert.AreEqual(expected, result);
        }
    }
}
