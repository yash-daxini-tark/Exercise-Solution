using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    #region 5. MovingAvg

    public class MovingAvg
    {
        public double difference(int k, double[] data)
        {
            List<double> averages = new List<double>();
            double maxSum = 0, minSum = 0, curSum = 0;
            curSum = data.Take(k).Sum();
            maxSum = curSum;
            minSum = curSum;
            for (int i = k; i <= data.Length - 1; i++)
            {
                curSum -= data[i - k];
                curSum += data[i];
                maxSum = Math.Max(maxSum, curSum);
                minSum = Math.Min(minSum, curSum);
            }
            maxSum /= k; minSum /= k;
            return maxSum - minSum;
        }
    }

    #endregion
}
