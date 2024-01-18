using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    #region 4. PalindromeDecoding

    public class PalindromeDecoding
    {
        public string decode(string code, int[] position, int[] length)
        {
            StringBuilder decodedString = new StringBuilder(code);
            for (int i = 0; i < position.Length; i++)
            {
                int positionOfInsertion = position[i] + length[i];
                StringBuilder substringOfCode;
                substringOfCode = new StringBuilder(decodedString.ToString().Substring(position[i], length[i]));
                string revString = new string(substringOfCode.ToString().Reverse().ToArray());
                decodedString.Insert(positionOfInsertion, revString);
            }
            return decodedString.ToString();
        }
    }

    #endregion
}
