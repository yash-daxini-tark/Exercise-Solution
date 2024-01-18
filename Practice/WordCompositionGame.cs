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
        static void addIntoMap(string[] list,Dictionary<string,int> countOfCharacters)
        {
            foreach (string str in list)
            {
                if (countOfCharacters.ContainsKey(str))
                {
                    int val = countOfCharacters[str];
                    countOfCharacters.Remove(str);
                    countOfCharacters.Add(str, val + 1);
                }
                else countOfCharacters.Add(str, 1);
            }
        }
        static int calculateScore(string[] list,Dictionary<string,int> countOfCharacters) 
        {
            int score = 0;
            foreach (string str in list)
            {
                if (countOfCharacters[str] == 1)
                {
                    score += 3;
                }
                else if (countOfCharacters[str] == 2)
                {
                    score += 2;
                }
                else
                {
                    score += 1;
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
