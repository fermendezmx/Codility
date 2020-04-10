using Codility.Training.Lesson3.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.UnitTest.Lesson3
{
    [TestClass]
    public class TPermMissingElem
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] input = { 2, 3, 1, 5 };
            int expected = 4;
            int result = PermMissingElem.Solution(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] input = { 8, 9, 4, 3, 1, 5, 2, 6 };
            int expected = 7;
            int result = PermMissingElem.Solution(input);

            Assert.AreEqual(expected, result);
        }
    }
}
