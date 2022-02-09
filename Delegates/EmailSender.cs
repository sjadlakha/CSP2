using System;
namespace Delegates
{
    public class EmailSender
    {
        private int sendResult;
        public int SendEmail()
        {
            Console.WriteLine("Sending the email....");
            sendResult = 0;
            return sendResult;
        }
    }
}
