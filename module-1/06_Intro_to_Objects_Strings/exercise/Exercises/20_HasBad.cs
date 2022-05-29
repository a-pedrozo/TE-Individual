namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return true if "bad" appears starting at index 0 or 1 in the string, such as with
        "badxxx" or "xbadxx" but not "xxbadxx". The string may be any length, including 0. Note: use .equals()
        to compare 2 strings.
        HasBad("badxx") → true
        HasBad("xbadxx") → true
        HasBad("xxbadxx") → false
        */
        public bool HasBad(string str)
        {
            string wordLength = str.Substring(0, 2);

            if (str.Length <= 2)
            {
                return false;
            }
            else if (str.Contains("bad"))
            {
                return true;
            }
            else if (str.Equals(wordLength))
            {
                if (wordLength.Contains("bad"))
                {
                    return true;
                }
            }

            return true;
        }
    }
}
