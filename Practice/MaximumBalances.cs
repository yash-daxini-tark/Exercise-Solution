using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    #region 8. MaximumBalances

    public class MaximumBalances
    {
        public int solve(string s)
        {
            int openBrackets = 0, closeBrackets = 0;
            foreach (char c in s)
            {
                if (c == '(') openBrackets++;
                else closeBrackets++;
            }
            int min = Math.Min(openBrackets, closeBrackets);
            return min * (min + 1) / 2;
        }
    }

    #endregion
}
