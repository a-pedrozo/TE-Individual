namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string of even length, return the first half. So the string "WooHoo" yields "Woo".
        FirstHalf("WooHoo") → "Woo"
        FirstHalf("HelloThere") → "Hello"
        FirstHalf("abcdef") → "abc"
        */
        public string FirstHalf(string str)
        { // calculate midpoint of my string 
            int midpoint = str.Length / 2;
            // chop it in half and give me first half 
            return str.Substring(0,midpoint);
        }
    }
}
