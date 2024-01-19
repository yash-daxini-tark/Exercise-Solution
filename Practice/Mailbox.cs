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
            Dictionary<char, int> countOfCharactersInCollection = new Dictionary<char, int>();
            foreach (char c in collection)
            {
                if (!countOfCharactersInCollection.ContainsKey(c))
                {
                    countOfCharactersInCollection[c] = 1;
                }
                else countOfCharactersInCollection[c] = countOfCharactersInCollection[c] + 1;
            }
            int impossibleAddresses = 0;
            foreach (string s in address)
            {
                var charactersAndItsCount = from char ch in s.ToCharArray()
                                            group ch by ch;
                foreach (var ch in charactersAndItsCount)
                {
                    var key = ch.Key;
                    var value = ch.Count();
                    if (key == ' ') continue;
                    if (!countOfCharactersInCollection.ContainsKey(key) || countOfCharactersInCollection[key] < value)
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
