using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    #region 13. PrintScheduler

    public class PrintScheduler
    {
        public string getOutput(string[] threads, string[] slices)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < threads.Length; i++)
            {
                map.Add(i, 0);
            }
            StringBuilder outputString = new StringBuilder();
            for (int i = 0; i < slices.Length; i++)
            {
                string cur = slices[i];
                int indexOfThread = Convert.ToInt32(cur.Split(" ")[0]);
                int lenghtToTakeInThread = Convert.ToInt32(cur.Split(" ")[1]);
                int prevIndexInThread = map[indexOfThread];
                while (lenghtToTakeInThread-- > 0)
                {
                    outputString.Append(threads[indexOfThread][prevIndexInThread]);
                    prevIndexInThread++;
                    prevIndexInThread %= threads[indexOfThread].Length;
                }
                map[indexOfThread] = prevIndexInThread;

            }
            return outputString.ToString();
        }
    }

    #endregion
}
