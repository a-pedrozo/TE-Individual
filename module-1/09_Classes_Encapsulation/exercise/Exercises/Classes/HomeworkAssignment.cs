namespace Exercises.Classes
{
    public class HomeworkAssignment
    {
        public int EarnedMarks { get; set; }
        public int PossibleMarks { get; private set; }
        public string SubmitterName { get; private set; }


        public string LetterGrade
        {
            get
            {
                if (EarnedMarks * 100 / PossibleMarks >= 90)
                {
                    return "A";

                }
                else if (EarnedMarks * 100 / PossibleMarks >= 80)
                {
                    return "B";
                }
                else if (EarnedMarks * 100 / PossibleMarks >= 70)
                {
                    return "C";
                }
                else if (EarnedMarks * 100 / PossibleMarks >= 60)
                {
                    return "D";
                } else
                {
                    return "F"; 
                }

            }

        }

        public HomeworkAssignment(int possibleMarks, string submitterName)
        {
            this.PossibleMarks = possibleMarks;
            this.SubmitterName = submitterName;
            
        }
    }
}
