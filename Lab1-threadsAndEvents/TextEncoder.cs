using System;
using System.Threading;

namespace Lab1_threadsAndEvents
{
    public class TextEncoder
    {
        //delegate - a pointer to functions
        public delegate void CallAll(Object source, EventArgs args);

        //event handler
        public event CallAll EventHandler;

        public void Encode(string msg)
        {
            Console.WriteLine($"Encoding text {msg}...");
            Thread.Sleep(2000);

            MyEvent();
            Thread.Sleep(1000);
        }

        //event
        protected virtual void MyEvent()
        {
            //apeleaza EventHandler daca nu e NULL
            EventHandler?.Invoke(this, EventArgs.Empty);
        }

    }
}
