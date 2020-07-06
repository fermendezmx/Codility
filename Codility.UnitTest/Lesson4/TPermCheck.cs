using Codility.Training.Lesson4.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.UnitTest.Lesson4
{
    [TestClass]
    public class TPermCheck
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] input = { 4, 1, 3, 2 };
            int expected = 1;
            int result = PermCheck.Solution(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] input = { 4, 1, 3 };
            int expected = 0;
            int result = PermCheck.Solution(input);

            Assert.AreEqual(expected, result);
        }
    }
}
