using System;
using System.Collections.Generic;
using System.Linq;
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
            for (int i = 0; i <= data.Length - k; i++)
            {
                double curSum = 0;
                for (int j = i; j < i + k; j++)
                {
                    curSum += data[j];
                }
                curSum /= k;
                averages.Add(curSum);
            }
            averages.Sort();
            return averages[averages.Count - 1] - averages[0];
        }
    }

    #endregion
}
