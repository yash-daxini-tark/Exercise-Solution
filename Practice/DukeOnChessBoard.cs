using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    #region 9. DukeOnChessBoard

    public class DukeOnChessBoard
    {
        static StringBuilder ans;
        public void doRecursion(int i, int j, int n, HashSet<string> set, Dictionary<int, char> map, bool[,] visited, string cur)
        {
            if (i < 1 || i > n || j < 1 || j > n || visited[i, j])
            {
                set.Add(cur.ToString());
                cur = new string("");
                return;
            }
            visited[i, j] = true;
            cur += map[i] + "" + j + '-';
            doRecursion(i + 1, j, n, set, map, visited, cur);
            doRecursion(i, j + 1, n, set, map, visited, cur);
            doRecursion(i, j - 1, n, set, map, visited, cur);
            doRecursion(i - 1, j, n, set, map, visited, cur);
        }
        public string dukePath(int n, string initPosition)
        {
            int initX = (int)initPosition[0];
            initX -= 96;
            int initY = initPosition[1] - '0';
            Dictionary<int, char> map = new Dictionary<int, char>();
            for (int i = 1; i <= n; i++)
            {
                map.Add(i, (char)(i + 96));
            }
            ans = new StringBuilder();
            bool[,] visited = new bool[n + 1, n + 1];
            for (int i = 0; i <= n; i++)
            {
                visited[0, i] = true;
                visited[i, 0] = true;
            }

            HashSet<string> set = new HashSet<string>();

            doRecursion(initX, initY, n, set, map, visited, new string(""));

            List<string> list = new List<string>(set);

            list.Sort();

            ans = new StringBuilder(list[list.Count - 1]);
            if (ans.Length == 0) return ans.ToString();

            string tempStr = new string(ans.ToString().Substring(0, ans.Length - 1));

            if (tempStr.Length > 40)
            {
                ans = new StringBuilder(tempStr.ToString().Substring(0, 20) + "..." + tempStr.ToString().Substring(tempStr.Length - 20));
            }
            else ans = new StringBuilder(tempStr);
            return ans.ToString();
        }
    }

    #endregion
}
