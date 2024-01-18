using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    #region 7. LargestSubsequence

    public class LargestSubsequence
    {
        public void doRecursion(string s, int i, HashSet<string> set, StringBuilder cur)
        {
            if (i == s.Length)
            {
                set.Add(cur.ToString());
                return;
            }
            cur.Append(s[i]);
            doRecursion(s, i + 1, set, cur);
            cur.Remove(cur.Length - 1, 1);
            doRecursion(s, i + 1, set, cur);
        }
        public string getLargest(String s)
        {
            List<int> indexesOfMaxCharacter = new List<int>();
            char max = s[0];
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] > max)
                {
                    max = s[i];
                }
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == max) indexesOfMaxCharacter.Add(i);
            }
            HashSet<string> set = new HashSet<string>();
            foreach (int i in indexesOfMaxCharacter)
            {
                doRecursion(s, i, set, new StringBuilder(""));
            }
            List<string> list = new List<string>(set);
            list.Sort();
            return list[list.Count - 1];
        }
    }

    #endregion
}
