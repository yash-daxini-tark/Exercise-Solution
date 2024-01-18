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
                        if (i - 1 >= 0 && kingdom[i - 1][j] == '.') c++;
                        if (i - 1 >= 0 && j + 1 < m && kingdom[i - 1][j + 1] == '.') c++;
                        if (j - 1 >= 0 && kingdom[i][j - 1] == '.') c++;
                        if (j + 1 < m && kingdom[i][j + 1] == '.') c++;
                        if (i + 1 < n && j < m && kingdom[i + 1][j] == '.') c++;
                        if (i + 1 < n && j + 1 < m && kingdom[i + 1][j + 1] == '.') c++;
                        countOfBeaches += c;
                    }
                    else if (kingdom[i][j] == '#')
                    {
                        if (i - 1 >= 0 && j - 1 >= 0 && kingdom[i - 1][j - 1] == '.') c++;
                        if (i - 1 >= 0 && kingdom[i - 1][j] == '.') c++;
                        if (j - 1 >= 0 && kingdom[i][j - 1] == '.') c++;
                        if (j + 1 < m && kingdom[i][j + 1] == '.') c++;
                        if (i + 1 < n && j - 1 >= 0 && kingdom[i + 1][j - 1] == '.') c++;
                        if (i + 1 < n && j < m && kingdom[i + 1][j] == '.') c++;
                        countOfBeaches += c;
                    }
                }
            }

            return countOfBeaches;
        }

    }

    #endregion
}
