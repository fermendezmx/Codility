using Codility.Training.Lesson2.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.UnitTest.Lesson2
{
    [TestClass]
    public class TOddOccurrenceInArray
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] input = { 9, 3, 9, 3, 9, 7, 9 };
            int expected = 7;
            int result = OddOccurrenceInArray.Solution(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] input = { 1, 2, 3, 4, 5, 6, 2, 4, 6, 1, 3 };
            int expected = 5;
            int result = OddOccurrenceInArray.Solution(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] input = { 1, 3, 1 };
            int expected = 3;
            int result = OddOccurrenceInArray.Solution(input);

            Assert.AreEqual(expected, result);
        }
    }
}
