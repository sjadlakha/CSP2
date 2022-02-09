using System;
namespace Delegates
{
    public class Document
    {
        public string Text { get; set; }
        // delegate that can be used by the client of this class
        public delegate int SendDoc();

        public void ReportSendingResult(SendDoc sendingDelegate)
        {
            if (sendingDelegate() == 0)
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Unable to send!");
            }
        }
    }
}
