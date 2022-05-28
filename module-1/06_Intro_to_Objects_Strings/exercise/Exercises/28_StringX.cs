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
            string firstX = str.Substring(0, 1);
            string lastX = str.Substring(str.Length - 1, 1);
            
            if (!(firstX.Contains("x")))
            {
                firstX.Replace(str.Substring(0,1), "");
            }
            
            return firstX + minusX + lastX;

        }
    }
}
