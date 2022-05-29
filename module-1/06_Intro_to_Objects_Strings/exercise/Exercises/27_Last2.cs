namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return the count of the number of times that a substring length 2 appears in the string and
        also as the last 2 chars of the string, so "hixxxhi" yields 1 (we won't count the end substring).
        Last2("hixxhi") → 1
        Last2("xaxxaxaxx") → 1
        Last2("axxxaaxx") → 2
        */
        public int Last2(string str)
        {
            if(str.Length < 3)
            {
                return 0;
            }
            
            string last2 = str.Substring(str.Length -2, 2);
            string strMinus2 = str.Substring(0, str.Length - 2);
            int counter = 0;
            
            if (strMinus2.Contains(last2) == true)
            {
                for (int i = 0; i <= strMinus2.Length - 2; i++)
                {
                    if(strMinus2.Substring(i, 2) == last2)
                    {
                        counter += 1;
                    }
                }
            } 

            
            return counter;
        }
    }
}
