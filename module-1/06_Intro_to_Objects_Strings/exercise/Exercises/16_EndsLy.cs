namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return true if it ends in "ly".
        EndsLy("oddly") → true
        EndsLy("y") → false
        EndsLy("oddy") → false
        */
        public bool EndsLy(string str)
        {
            string endsWith = str;
            if (endsWith == str.Substring(str.Length - 2, 2))
            {
                if (endsWith.Contains("ly"))
                {
                    return true;
                }

               else if (!(endsWith == str.Substring(str.Length - 2, 2)))
                {
                    return false;
                }
            }

            return false;
            

        }
    }
}
