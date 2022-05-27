namespace Exercises.Classes
{
    public class Elevator
    {
        public int CurrentLevel { get; private set; }
        public int NumberOfLevels { get; private set; }
        public bool DoorlsOpen { get; private set; }

        public Elevator(int numberOfLevels)
        {
            this.CurrentLevel = numberOfLevels;//??
        }

        public void OpenDoor()
        {

        }
        public void CloseDorr()
        {

        }
        public void GoUp(int desiredFloor)
        {

        }
        public void GoDown(int desiredFloor)
        {

        }

    }
}
