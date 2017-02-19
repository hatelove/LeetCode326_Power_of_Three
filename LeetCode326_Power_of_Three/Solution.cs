using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode326_Power_of_Three
{
    public class Solution
    {
        public bool IsPowerOfThree(int n)
        {
            var o = Math.Log(n, 3);

            var r = o % 1;

            return r == 0;
        }
    }
}
