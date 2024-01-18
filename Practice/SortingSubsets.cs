using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    #region 3. SortingSubsets
    public class SortingSubsets
    {
        public int getMinimalSize(int[] a)
        {
            List<int> sortedList = new List<int>();
            for (int i = 0; i < a.Length; i++)
            {
                sortedList.Add(a[i]);
            }
            Array.Sort(a, 0, a.Length);
            int smallestSizeOfSet = 0;
            for (int i = 0; i < a.Length; ++i)
            {
                if (a[i] != sortedList[i]) { smallestSizeOfSet++; }
            }
            return smallestSizeOfSet;
        }
    }
    #endregion
}
