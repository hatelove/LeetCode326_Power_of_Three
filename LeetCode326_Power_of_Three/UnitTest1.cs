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
            Assert.IsTrue(new Solution().IsPowerOfThree(n));
        }
    }
}
