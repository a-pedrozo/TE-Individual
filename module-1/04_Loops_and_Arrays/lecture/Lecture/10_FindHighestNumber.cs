namespace Lecture
{
    public partial class LectureProblem
    {
        /*
        10. What code do we need to write so that we can find the highest
             number in the array randomNumbers?
             TOPIC: Looping Through Arrays
        */
        public int FindTheHighestNumber(int[] randomNumbers)
        {
            int highest = randomNumbers[0]; // assumes first item is the highest 
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                int number = randomNumbers[i];
                if (number > highest)
                {
                    highest = number;
                }
            }
            
            return highest;
        }
    }
}
