using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    #region 12. MysticAndCandiesEasy
    public class MysticAndCandiesEasy
    {
        public int minBoxes(int C, int X, int[] high)
        {
            int smallestNumberOfBoxes = 0;
            Array.Sort(high);
            List<int> list = new List<int>();
            int n = high.Length;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if ((sum + high[i]) >= C)
                {
                    list.Add(C - sum);
                    sum += C - sum;
                }
                else
                {
                    sum += high[i];
                    list.Add(high[i]);
                }
                smallestNumberOfBoxes++;
                if (sum == C) break;
            }
            for (int i = smallestNumberOfBoxes; i < n; ++i)
            {
                list.Add(0);
            }
            smallestNumberOfBoxes = 0;
            sum = 0;
            for (int i = list.Count - 1; i >= 0; i--)
            {
                sum += list[i];
                smallestNumberOfBoxes++;
                if (sum >= X) break;
            }

            return smallestNumberOfBoxes;
        }
    }
    #endregion
}
