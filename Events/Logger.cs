using System;
namespace Events
{
    public class Logger
    {
        public void Subscribe(Clock theClock)
        {
            //subscribe to the event 
            //    theClock.TimeChanged += new Clock.TimeChangeHandler(NewTime);
            //}

            //private void NewTime(object theClock, TimeEventArgs e)
            //{
            //    // This method is executed when the event is raised
            //    Console.WriteLine("Logging event at: {0}:{1}:{2}",
            //        e.Hour.ToString(),
            //        e.Minute.ToString(),
            //        e.Second.ToString());
            //}

            theClock.TimeChanged +=
                (sender, e) =>
                {
                    Console.WriteLine("Logging event at: {0}:{1}:{2}",
                    e.Hour.ToString(),
                    e.Minute.ToString(),
                    e.Second.ToString());
                };
        }
    }
}
