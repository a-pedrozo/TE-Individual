using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Just when you thought it was safe to get back in the water --- Last2Revisited!!!!
         *
         * Given an array of strings, for each string, the count of the number of times that a substring length 2 appears
         * in the string and also as the last 2 chars of the string, so "hixxxhi" yields 1.
         *
         * We don't count the end substring, but the substring may overlap a prior position by one.  For instance, "xxxx"
         * has a count of 2, one pair at position 0, and the second at position 1. The third pair at position 2 is the
         * end substring, which we don't count.
         *
         * Return Dictionary<string, int>, where the key is string from the array, and its last2 count.
         *
         * Last2Revisited(["hixxhi", "xaxxaxaxx", "axxxaaxx"]) → {"hixxhi": 1, "xaxxaxaxx": 1, "axxxaaxx": 2}
         *
         */
        public Dictionary<string, int> Last2Revisited(string[] words)
        {
            Dictionary<string, int> lastTwoDict = new Dictionary<string, int>();

            if (words.Length > 0)
            {
                for (int i = 0; i <= words.Length - 1; i++)
                {
                    if (words[i].Length > 1)
                    {
                        string last2 = words[i].Substring(words[i].Length - 2, 2);
                        string strMinus2 = words[i].Substring(0, words[i].Length - 2);
                        int counter = 0;
                        if (strMinus2.Contains(last2) == true)
                        {
                            for (int l = 0; l <= strMinus2.Length - 2; l++)
                            {
                                if (strMinus2.Substring(l, 2) == last2)
                                {
                                    counter += 1;
                                }
                            }
                            lastTwoDict[words[i]] = counter;
                        }
                        else
                        {
                            lastTwoDict[words[i]] = counter;
                        }
                    }
                }

                return lastTwoDict;
            }
            return lastTwoDict;
        }      
    }
}
