namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return a version where all the "x" have been removed. Except an "x" at the very start or end
        should not be removed.
        StringX("xxHxix") → "xHix"
        StringX("abxxxcd") → "abcd"
        StringX("xabxxxcdx") → "xabcdx"
        */
        public string StringX(string str)
        {
            string minusX = str.Replace("x", "");

            if (str.Length <= 1)
                return str;
            else
            {
                string firstLetter = str.Substring(0, 1);
                string lastLetter = str.Substring(str.Length - 1, 1);
                if (firstLetter.Contains("x") && lastLetter.Contains("x"))
                    return firstLetter + minusX + lastLetter;
                else if (firstLetter.Contains("x"))
                    return firstLetter + minusX;
                else if (lastLetter.Contains("x"))
                    return minusX + lastLetter;
                else
                    return minusX;
            }
        }
    }
}
