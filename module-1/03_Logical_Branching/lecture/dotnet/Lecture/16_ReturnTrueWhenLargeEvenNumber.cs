namespace Lecture
{
    public partial class LectureExample
    {
        /*
        16. Return "Big Even Number" when number is even, larger than 100, and a multiple of 5.
            Return "Big Number" if the number is just larger than 100.
            Return empty string for everything else.
            TOPIC: Complex Expression
        */
        public string ReturnBigEvenNumber(int number)
        {
            bool isMultipleOfFive = false;
            if (number % 5 == 0)// if it divides evenly by 5
            {
                isMultipleOfFive = true;
            }
            if (number > 100)
            {
                if (number % 2 == 0) // divides evenly by 2

                {
                    if (isMultipleOfFive)
                    {
                        return "Big Even Number";
                    }
                }
                return "Big number";
            }
            return "";
        }
    }
}
