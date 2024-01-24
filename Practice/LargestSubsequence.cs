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
        public void findPossibleSubsequence(string s, int i, HashSet<string> set, StringBuilder cur)
        {
            if (i == s.Length)
            {
                set.Add(cur.ToString());
                return;
            }
            cur.Append(s[i]);
            findPossibleSubsequence(s, i + 1, set, cur);
            cur.Remove(cur.Length - 1, 1);
            findPossibleSubsequence(s, i + 1, set, cur);
        }
        public string getLargest(String s)
        {
            char max = s.ToCharArray().Max();
            List<int> indexesOfMaxCharacter = (from char ch in s.ToCharArray()
                                               where ch == max
                                               select s.IndexOf(ch)).ToList();

            HashSet<string> set = new HashSet<string>();
            foreach (int i in indexesOfMaxCharacter)
            {
                findPossibleSubsequence(s, i, set, new StringBuilder(""));
            }
            return set.Max();
        }
    }

    #endregion
}
