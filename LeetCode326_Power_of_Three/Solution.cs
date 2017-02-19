using System;

namespace LeetCode326_Power_of_Three
{
    public class Solution
    {
        public bool IsPowerOfThree(int n)
        {
            if (n <= 0) return false;
            
            var o = (decimal)Math.Log(n, 3);

            var r = o % 1;

            return r == 0;
        }
    }
}