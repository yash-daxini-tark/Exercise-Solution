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
        static StringBuilder lexicographicallyLargetstPath = new StringBuilder();
        public char giveCharacterFromIndex(int index)
        {
            return (char)(index + 97);
        }
        public bool validatePosition(int i, int j, int n, bool[,] visited)
        {
            return i < n && j < n && i >= 0 && j >= 0 && !visited[i, j];
        }
        public string findLexicographicallyLargestPath(int i, int j, int n, bool[,] visited, StringBuilder lexicographicallyLargetstPath)
        {
            while (true)
            {
                if (validatePosition(i + 1, j, n, visited)) i++;
                else if (validatePosition(i, j + 1, n, visited)) j++;
                else if (validatePosition(i, j - 1, n, visited)) j--;
                else if (validatePosition(i - 1, j, n, visited)) i--;
                else break;
                lexicographicallyLargetstPath.Append(giveCharacterFromIndex(i) + "" + (j + 1) + "-");
                visited[i, j] = true;
            }
            return lexicographicallyLargetstPath.ToString();
        }
        public string dukePath(int n, string initPosition)
        {
            int initX = (int)initPosition[0] - 97;
            int initY = initPosition[1] - '0' - 1;
            bool[,] visited = new bool[n, n];
            lexicographicallyLargetstPath = new StringBuilder(initPosition + "-");
            visited[initX, initY] = true;

            findLexicographicallyLargestPath(initX, initY, n, visited, lexicographicallyLargetstPath);

            if (lexicographicallyLargetstPath.Length == 0) return lexicographicallyLargetstPath.ToString();
            lexicographicallyLargetstPath.Remove(lexicographicallyLargetstPath.Length - 1, 1);

            if (lexicographicallyLargetstPath.Length > 40)
            {
                lexicographicallyLargetstPath = new StringBuilder(lexicographicallyLargetstPath.ToString().Substring(0, 20) + "..." + lexicographicallyLargetstPath.ToString().Substring(lexicographicallyLargetstPath.Length - 20));
            }
            return lexicographicallyLargetstPath.ToString();
        }
    }

    #endregion
}
