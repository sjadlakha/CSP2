using System;
using System.Threading;

namespace Events
{// publisher class
    public class Clock // no UI, just notify the subs when the clock advances
    {
        private int hour;
        private int minute;
        private int second;

        public delegate void TimeChangeHandler(object clock, TimeEventArgs timeInfo); // runs everytime time changes (event occurs)
        public event TimeChangeHandler TimeChanged; // event that other classes will subscribe to

        public void RunClock()
        {
            while (true)
            {
                Thread.Sleep(100);
                DateTime currentTime = DateTime.Now;
                if (currentTime.Second != this.second) // if time changes i.e event occurs
                {
                    TimeEventArgs timeEventArgs = new TimeEventArgs()
                    {
                        Hour = currentTime.Hour,
                        Minute = currentTime.Minute,
                        Second = currentTime.Second
                    };

                    if (TimeChanged != null) // if anyone is subscribed to the event
                    {
                        TimeChanged(this, timeEventArgs); // raise the event
                    }

                    // tidy up for next event
                    this.second = currentTime.Second;
                    this.hour= currentTime.Hour;
                    this.minute = currentTime.Minute;
                }

            }
        }
    }
}
