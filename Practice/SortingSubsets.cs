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
            int[] sortedArray = a.OrderBy((number) => number).ToArray();
            int smallestSizeOfSet = 0;
            for (int i = 0; i < a.Length; ++i)
            {
                if (a[i] != sortedArray[i]) { smallestSizeOfSet++; }
            }
            return smallestSizeOfSet;
        }
    }
    #endregion
}
