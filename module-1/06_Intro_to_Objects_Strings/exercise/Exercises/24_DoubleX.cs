namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return true if the first instance of "x" in the string is immediately followed by another "x".
        DoubleX("axxbb") → true
        DoubleX("axaxax") → false
        DoubleX("xxxxx") → true
        */
        public bool DoubleX(string str)
        {
            for (int i = 0; i <= str.Length - 2; i++)
            {
                if (str.Substring(i, 1).Equals("x"))
                {
                    if (str.Substring(i + 1, 1).Equals("x"))
                    {
                        return true;

                    }
                    else return false;
                }

            }
            return false;

        }
    }
}
