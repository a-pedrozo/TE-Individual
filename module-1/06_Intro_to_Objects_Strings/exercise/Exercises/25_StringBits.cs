namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return a new string made of every other char starting with the first, so "Hello" yields "Hlo".
        StringBits("Hello") → "Hlo"
        StringBits("Hi") → "H"
        StringBits("Heeololeo") → "Hello"
        */
        public string StringBits(string str)
        {
            string newBit = "";
            if (str.Length.Equals(""))
            {
                return newBit;
            }

            for (int i = 1; i <= str.Length; i++)
            {
                if (i % 2 == 1) // keep odds skip evens
                {
                    newBit += str.Substring(i - 1, 1);
                }
            } 
 
            return newBit;
        }
    }
}
