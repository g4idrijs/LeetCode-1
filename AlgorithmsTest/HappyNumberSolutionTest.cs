using System.Diagnostics;
using Algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsTest
{
    [TestClass]
    public class HappyNumberSolutionTest
    {
        [TestMethod]
        public void isHappyTest()
        {
            var solution = new HappyNumberSolution();
            Assert.IsTrue(solution.isHappy(1));
            Assert.IsFalse(solution.isHappy(2));
            Assert.IsTrue(solution.isHappy(19));
            Trace.WriteLine(solution.isHappy(39166461));
        }
    }
}
