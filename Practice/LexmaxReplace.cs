﻿using System;
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
            char[] c = t.ToCharArray();
            Array.Sort(c);
            int curIndexOfT = c.Length - 1;
            for (; i < s.Length && curIndexOfT >= 0; i++)
            {
                if (s[i] >= c[curIndexOfT])
                {
                    largestString.Append(s[i]);
                }
                else largestString.Append(c[curIndexOfT--]);
            }
            for (; i < s.Length; i++) largestString.Append(s[i]);
            return largestString.ToString();
        }
    }
    #endregion
}
