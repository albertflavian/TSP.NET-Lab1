using System;
using System.Threading;
using System.ComponentModel;

namespace Lab1_threadsAndEvents
{

    public class Program
    {

        static void Main()
        {
            string text = "Message";
            var textEncoder = new TextEncoder(); //publisher
            var mailService = new MailService(); //subscriber


            //adaugam SendTextMessage in lista de subscriberi
            textEncoder.EventHandler += mailService.SendTextMessage;
            //adaugam SendVideoMessage in lista de subscriberi
            textEncoder.EventHandler += mailService.SendVideoMessage;

            textEncoder.Encode(text);

            int number = 10000;
            Thread t1 = new Thread(() => Prim.Problem2(number, Prim.Alg1));
            Thread t2 = new Thread(() => Prim.Problem2(number, Prim.Alg2));
            t1.Name = "Alg1";
            t2.Name = "Alg2";
            t2.Start();
            Thread.Sleep(100);
            t1.Start();

           

        }
    }
}
