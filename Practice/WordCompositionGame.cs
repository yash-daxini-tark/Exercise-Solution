using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    #region 6. WordCompositionGame
    public class WordCompositionGame
    {
        static int calculateScore(string[] list, Dictionary<string, int> countOfCharacters)
        {
            int score = 0;
            foreach (string str in list)
            {
                switch (countOfCharacters[str])
                {
                    case 1:
                        score += 3;
                        break;
                    case 2:
                        score += 2;
                        break;
                    case 3:
                        score += 1;
                        break;
                }
            }
            return score;
        }
        public string score(string[] listA, string[] listB, string[] listC)
        {
            string[] combinedList = listA.Concat(listB).Concat(listC).ToArray();
            var groupAndCount = combinedList.GroupBy((str) => str).Select(str =>
            new
            {
                key = str.Key,
                count = Convert.ToInt32(str.Count())
            });
            Dictionary<string, int> countOfCharactersInLists = groupAndCount.ToDictionary(str => str.key, str => str.count);
            int scoreOfA = calculateScore(listA, countOfCharactersInLists);
            int scoreOfB = calculateScore(listB, countOfCharactersInLists);
            int scoreOfC = calculateScore(listC, countOfCharactersInLists);
            return scoreOfA + "/" + scoreOfB + "/" + scoreOfC;

        }

    }

    #endregion
}
