using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    #region 14. TurningLightOn

    public class TurningLightOn
    {
        public int minFlips(string[] board)
        {
            int m = board.Length;
            int n = board[0].Length;
            int[] operations = new int[n];
            bool isZero = true;
            for (int i = m - 1; i >= 0; i--)
            {
                int curOperations = 0;
                bool[] curStringBits = new bool[n];
                for (int j = 0; j < n; j++)
                {
                    curStringBits[j] = board[i][j] == '1' ? true : false;
                }
                isZero = true;
                for (int j = n - 1; j >= 0; j--)
                {
                    curStringBits[j] = ((operations[j] & 1) == 0 ? curStringBits[j] : !curStringBits[j]);
                    if (isZero && !curStringBits[j])
                    {
                        curOperations++;
                    }
                    else if (!isZero && curStringBits[j])
                    {
                        curOperations++;
                    }
                    else
                    {
                        operations[j] += curOperations;
                        continue;
                    }
                    isZero = !isZero;
                    operations[j] += curOperations;
                }
            }

            return operations[0];
        }
    }

    #endregion
}
