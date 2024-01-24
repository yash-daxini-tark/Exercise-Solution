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
            Dictionary<string, char> encodedStrings = new Dictionary<string, char>();
            for (int i = 0; i < dictionary.Length; i++)
            {
                encodedStrings.Add(dictionary[i], (char)(65 + i));
            }

            int lastDecodedIndex = 0;
            StringBuilder decodedString = new StringBuilder();
            int sizeOfDictionary = archive.Length;

            for (int i = 0; i < sizeOfDictionary; i++)
            {
                string presetStringToDecode = (i == sizeOfDictionary - 1 ? archive.Substring(lastDecodedIndex) : archive.Substring(lastDecodedIndex, (i - lastDecodedIndex + 1)));
                if (encodedStrings.ContainsKey(presetStringToDecode))
                {
                    decodedString.Append(encodedStrings[presetStringToDecode]);
                    lastDecodedIndex = i + 1;
                }
            }
            return decodedString.ToString();
        }
    }
    #endregion
}
