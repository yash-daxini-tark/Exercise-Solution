using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    #region 2. LexmaxReplace
    public class LexmaxReplace
    {
        public string get(string s, string t)
        {
            StringBuilder largestString = new StringBuilder("");
            int i = 0;
            char[] c = (from char ch in t.ToCharArray()
                        orderby ch ascending
                        select ch).ToArray();
            int curIndexOfT = c.Length - 1;
            for (; i < s.Length && curIndexOfT >= 0; i++)
            {
                if (s[i] >= c[curIndexOfT])
                {
                    largestString.Append(s[i]);
                }
                else largestString.Append(c[curIndexOfT--]);
            }
            largestString.Append(s.Substring(i));
            return largestString.ToString();
        }
    }
    #endregion
}
