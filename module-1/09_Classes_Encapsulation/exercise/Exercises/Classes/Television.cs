namespace Exercises.Classes
{
    public class Television
    {
        public bool IsOn { get; private set; }
        public int CurrentChannel { get; private set; }
        public int CurrentVolume { get; private set; }

        public Television(bool isOn, int currentChannel, int currentVolume)
        {
            this.CurrentChannel = currentChannel;
            this.CurrentVolume = currentVolume;
            this.IsOn = isOn;

        }
        public void TurnOff()
        {

        }
        public void TurnOn()
        {

        }
        public void ChangeChannel(int newChannel)
        {
            if(CurrentChannel >= 3 || CurrentChannel <= 18)
            {
               

            }

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
