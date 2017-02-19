using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode326_Power_of_Three
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void n_is_3_should_be_true()
        {
            var n = 3;
            ShouldBeTrue(n);
        }

        [TestMethod]
        public void n_is_6_should_be_false()
        {
            var n = 6;
            ShouldBeFalse(n);
        }

        [TestMethod]
        public void n_is_243_should_be_true()
        {
            ShouldBeTrue(243);
        }

        [TestMethod]
        public void n_is_0_should_be_false()
        {
            ShouldBeFalse(0);
        }
        private void ShouldBeFalse(int n)
        {
            Assert.IsFalse(new Solution().IsPowerOfThree(n));
        }

        private static void ShouldBeTrue(int n)
        {
            Assert.IsTrue(new Solution().IsPowerOfThree(n));
        }
    }
}
