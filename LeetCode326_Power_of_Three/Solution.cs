using System;

namespace LeetCode326_Power_of_Three
{
    public class Solution
    {
        public bool IsPowerOfThree(int n)
        {
            if (n <= 0) return false;

            return (decimal)Math.Log(n, 3) % 1 == 0;
        }
    }
}