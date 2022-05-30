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
        public bool DoubleX(string str) // test is incorrect 
        {
            for ( int i = 0; i <= str.Length - 2; i++)
            {
                if (str.Substring(i,1).Equals("x") && (str.Substring(i +1, 1).Equals("x")))
                {
                    return true;
                }
            }
           
            return false;
        }
    }
}
