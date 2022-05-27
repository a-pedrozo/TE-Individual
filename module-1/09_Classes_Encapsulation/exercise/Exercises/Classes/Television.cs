namespace Exercises.Classes
{
    public class Television
    {
        public bool IsOn { get; private set; }
        public int CurrentChannel { get; private set; }
        public int CurrentVolume { get; private set; }

        public Television(bool IsOn, int CurrentChannel, int CurrentVolume)
        {
            this.CurrentChannel = 3;
            this.CurrentVolume = 2;
            this.IsOn = false;

        }
        public void TurnOff()
        {

        }
        public void TurnOn()
        {

        }
        public void ChangeChannel(int newChannel)
        {

        }
        public void ChannelUp()
        {

        }
        public void ChannelDown()
        {

        }
        public void RaiseVolume()
        {

        }
        public void LowerVolume()
        {

        }
    }
}
