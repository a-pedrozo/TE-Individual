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
            if (number % 5 == 0) // If it divides evenly by 5
            {
                isMultipleOfFive = true;
            }

            if (number > 100) // Is it a big number?
            {
                // How do we check to see if it's a big even number?
                if (number % 2 == 0) // Divides evenly by 2 (even)
                {
                    if (isMultipleOfFive)
                    {
                        return "Big Even Number";
                    }

                }

                return "Big Number";
            }

            return "";
        }
    }
}
