namespace Exercises.Classes
{
    public class Airplane
    {
        public string PlaneNumber { get; private set; }
        public int TotalFirstClassSeats { get; private set; }
        public int BookedFirstClassSeats { get; private set; }

        public int TotalCoachSeats { get; private set; }
        public int BookedCoachSeats { get; private set; }


        public Airplane(string planeNumber, int totalFirstClassSeats, int totalCoachSeats)
        {
            this.PlaneNumber = planeNumber;
            this.TotalFirstClassSeats = totalFirstClassSeats;
            this.TotalCoachSeats = totalCoachSeats;
        }

        public int AvailableFirstClassSeats
        {
            get
            {
                int AvailableFirstClassSeats = TotalFirstClassSeats - BookedFirstClassSeats;
                return AvailableFirstClassSeats;
            }
        }

        public int AvailableCoachSeats
        {
            get
            {
                int AvailableCoachSeats = TotalCoachSeats - BookedCoachSeats;
                return AvailableCoachSeats;
            }
        }








        public bool ReserveSeats(bool forFirstClass, int totalNumberofSeats)
        {
            if (forFirstClass && this.AvailableFirstClassSeats >= totalNumberofSeats)
            {
                BookedFirstClassSeats += totalNumberofSeats;
                return true;
            }
            else if (!forFirstClass && this.AvailableCoachSeats >= totalNumberofSeats)
            {
                BookedCoachSeats += totalNumberofSeats;
                return true;
            }
            else
                return false;

        }




    }
}
