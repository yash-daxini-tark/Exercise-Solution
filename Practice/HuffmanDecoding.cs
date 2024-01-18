using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    #region 1. HuffmanDecoding
    public class HuffmanDecoding
    {
        public string decode(string archive, string[] dictionary)
        {
            Dictionary<string, int> encodedStrings = new Dictionary<string, int>();
            for (int i = 0; i < dictionary.Length; i++)
            {
                encodedStrings.Add(dictionary[i], i + 1);
            }

            StringBuilder stringTillIthIndex = new StringBuilder();
            StringBuilder decodedString = new StringBuilder();

            for (int i = 0; i < archive.Length; i++)
            {
                stringTillIthIndex.Append(archive[i]);
                if (encodedStrings.ContainsKey(stringTillIthIndex.ToString()))
                {
                    decodedString.Append((char)(64 + encodedStrings[stringTillIthIndex.ToString()]));
                    stringTillIthIndex = new StringBuilder();
                }
            }

            return decodedString.ToString();

        }
    }
    #endregion
}
