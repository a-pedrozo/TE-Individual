namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string and a non-negative int n, we'll say that the front of the string is the first 3 chars, or
        whatever is there if the string is less than length 3. Return n copies of the front;
        FrontTimes("Chocolate", 2) → "ChoCho"
        FrontTimes("Chocolate", 3) → "ChoChoCho"
        FrontTimes("Abc", 3) → "AbcAbcAbc"
        */
        public string FrontTimes(string str, int n)
        {



            string newString = "";
            string subString = "";

            if (str.Length < 3 && !str.Equals(""))
            {
                subString = str.Substring(0, str.Length);

            }
            else if (str.Length >= 3)
            {
                subString = str.Substring(0, 3);
                
            }
            else
            {
                return "";
            }
           
            

            for (int i = 0; i < n; i++)
            {
                newString += subString;
            }
            return newString;

        }

    }
}
