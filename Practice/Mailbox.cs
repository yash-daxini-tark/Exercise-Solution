using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    #region 11. Mailbox

    public class Mailbox
    {
        public int impossible(string collection, string[] address)
        {
            Dictionary<char, int> countOfCharacters = new Dictionary<char, int>();
            foreach (char c in collection)
            {
                if (!countOfCharacters.ContainsKey(c))
                {
                    countOfCharacters[c] = 1;
                }
                else countOfCharacters[c] = countOfCharacters[c] + 1;
            }
            int impossibleAddresses = 0;
            foreach (string s in address)
            {
                Dictionary<char, int> mapForEachString = new Dictionary<char, int>();
                foreach (char c in s)
                {
                    if (!mapForEachString.ContainsKey(c))
                    {
                        mapForEachString[c] = 1;
                    }
                    else mapForEachString[c] = mapForEachString[c] + 1;
                }
                foreach (char key in mapForEachString.Keys)
                {
                    if (key == ' ') continue;
                    if (!countOfCharacters.ContainsKey(key) || countOfCharacters[key] < mapForEachString[key])
                    {
                        impossibleAddresses++;
                        break;
                    }
                }
            }
            return impossibleAddresses;
        }

    }

    #endregion
}
