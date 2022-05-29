namespace Exercises.Classes
{
    public class Television
    {
        public bool IsOn { get; private set; }
        public int CurrentChannel { get; private set; } = 3;
        public int CurrentVolume { get; private set; } = 2;

      
        public void TurnOff()
        {
            if(IsOn == true)
            {
                IsOn = false;
                CurrentChannel = 0;
                CurrentVolume = 0;
            }
        }
        public void TurnOn()
        {
           if (IsOn == false)
            {
                IsOn = true;
                CurrentChannel = 3;
                CurrentVolume = 2;

            }
        }
        public void ChangeChannel(int newChannel)
        {
            if( IsOn == true && newChannel >= 3 && newChannel <= 18)
            {
                CurrentChannel = newChannel;

            }

        }
        public void ChannelUp()
        {
            if(IsOn == true  && CurrentChannel < 18)
            {
                CurrentChannel += 1;
            }
            else
            {
                CurrentChannel = 3;
            }
        }
        public void ChannelDown()
        {
            if (IsOn == true && CurrentChannel > 3)
            {
                CurrentChannel -= 1;
            }
            else if(IsOn == true)
            {
                CurrentChannel = 18;
            } 
           
        }
        public void RaiseVolume()
        {
            if(IsOn == true && CurrentVolume < 10)
            {
                CurrentVolume += 1;
            }
        }
        public void LowerVolume()
        {
            if (IsOn == true && CurrentVolume > 0)
            {
                CurrentVolume -= 1;
            }
        }
    }
}
