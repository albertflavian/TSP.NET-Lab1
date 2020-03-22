using System;

namespace Lab1_threadsAndEvents
{
    public class MailService
    {
        public void SendTextMessage(Object source, EventArgs args)
        {
            Console.WriteLine("subscriber1:Sending an text  email...");
        }
        public void SendVideoMessage(Object source, EventArgs args)
        {
            Console.WriteLine("subscriber2:Sending an video email...");
        }
    }
}
