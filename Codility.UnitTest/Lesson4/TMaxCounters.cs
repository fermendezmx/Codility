using Codility.Training.Lesson4.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.UnitTest.Lesson4
{
    [TestClass]
    public class TMaxCounters
    {
        [TestMethod]
        public void TestMethod1()
        {
            int n = 5;
            int[] input = { 3, 4, 4, 6, 1, 4, 4 };
            int[] expected = { 3, 2, 2, 4, 2 };
            int[] result = MaxCounters.Solution(n, input);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
