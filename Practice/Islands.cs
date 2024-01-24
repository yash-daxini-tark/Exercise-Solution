using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    #region 10. Islands

    public class Islands
    {
        public bool validatePosition(int x, int y, int n, int m, string[] kingdom)
        {
            return x >= 0 && y >= 0 && x < n && y < m && kingdom[x][y] == '.';
        }
        public int beachLength(string[] kingdom)
        {
            int countOfBeaches = 0;
            int n = kingdom.Length;
            int m = kingdom[0].Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int c = 0;
                    if (kingdom[i][j] == '#' && (i & 1) == 1)
                    {
                        if (validatePosition(i - 1, j, n, m, kingdom)) c++;
                        if (validatePosition(i - 1, j + 1, n, m, kingdom)) c++;
                        if (validatePosition(i, j - 1, n, m, kingdom)) c++;
                        if (validatePosition(i, j + 1, n, m, kingdom)) c++;
                        if (validatePosition(i + 1, j, n, m, kingdom)) c++;
                        if (validatePosition(i + 1, j + 1, n, m, kingdom)) c++;
                        countOfBeaches += c;
                    }
                    else if (kingdom[i][j] == '#')
                    {
                        if (validatePosition(i - 1, j - 1, n, m, kingdom)) c++;
                        if (validatePosition(i - 1, j, n, m, kingdom)) c++;
                        if (validatePosition(i, j - 1, n, m, kingdom)) c++;
                        if (validatePosition(i, j + 1, n, m, kingdom)) c++;
                        if (validatePosition(i + 1, j - 1, n, m, kingdom)) c++;
                        if (validatePosition(i + 1, j, n, m, kingdom)) c++;
                        countOfBeaches += c;
                    }
                }
            }

            return countOfBeaches;
        }

    }

    #endregion
}
