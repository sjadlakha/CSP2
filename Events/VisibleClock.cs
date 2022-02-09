using System;
namespace Events
{ // subscriber class
    public class VisibleClock
    {
        public void Subscribe(Clock theClock)
        {
            //subscribe to the event

            // Using delegate
            //    theClock.TimeChanged += new Clock.TimeChangeHandler(NewTime);
            //}

            //private void NewTime(object theClock, TimeEventArgs e)
            //{
            //    // This method is executed when the event is raised
            //    Console.WriteLine("{0}:{1}:{2}",
            //        e.Hour.ToString(),
            //        e.Minute.ToString(),
            //        e.Second.ToString());
            //}


            //using Anonymous functions

            //theClock.TimeChanged += delegate (object sender, TimeEventArgs e)
            //{
            //    Console.WriteLine("{0}:{1}:{2}",
            //        e.Hour.ToString(),
            //        e.Minute.ToString(),
            //        e.Second.ToString());
            //};

            //using Lambda Expressions

            theClock.TimeChanged +=
            ( sender,  e)=>
            {
                Console.WriteLine("{0}:{1}:{2}",
                    e.Hour.ToString(),
                    e.Minute.ToString(),
                    e.Second.ToString());
            };
        }
    }
}
