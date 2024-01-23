using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    #region 6. WordCompositionGame
    public class WordCompositionGame
    {
        static void addIntoMap(string[] list, Dictionary<string, int> countOfCharacters)
        {
            foreach (string str in list)
            {
                if (countOfCharacters.ContainsKey(str)) countOfCharacters[str] += 1;
                else countOfCharacters.Add(str, 1);
            }
        }
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
            Dictionary<string, int> countOfCharactersInLists = new Dictionary<string, int>();
            addIntoMap(listA, countOfCharactersInLists);
            addIntoMap(listB, countOfCharactersInLists);
            addIntoMap(listC, countOfCharactersInLists);
            int scoreOfA = calculateScore(listA, countOfCharactersInLists);
            int scoreOfB = calculateScore(listB, countOfCharactersInLists);
            int scoreOfC = calculateScore(listC, countOfCharactersInLists);
            return scoreOfA + "/" + scoreOfB + "/" + scoreOfC;

        }

    }

    #endregion
}
