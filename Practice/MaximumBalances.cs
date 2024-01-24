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
            int openBrackets = s.ToCharArray().Count((bracket) => bracket == '('), closeBrackets = s.ToCharArray().Count((bracket) => bracket == ')');
            int min = Math.Min(openBrackets, closeBrackets);
            return min * (min + 1) / 2;
        }
    }

    #endregion
}
