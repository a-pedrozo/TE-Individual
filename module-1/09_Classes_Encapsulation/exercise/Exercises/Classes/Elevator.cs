namespace Exercises.Classes
{
    public class Elevator
    {
        public int CurrentLevel { get; private set; } = 1;
        public int NumberOfLevels { get; private set; }
        public bool DoorIsOpen { get; private set; }

        public Elevator(int numberOfLevels)
        {
            this.NumberOfLevels = numberOfLevels;
           

        }

        public void OpenDoor()
        {
            if(DoorIsOpen == true)
            {

            }
        }
        public void CloseDoor()
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
