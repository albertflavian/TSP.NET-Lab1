using System;
using System.Threading;
namespace Lab1_threadsAndEvents
{
    class Program
    {

        static void Main()
        {
            int number = 10000;
            Thread t1 = new Thread(() => Prim.Problem2(number,Prim.Alg1));
            Thread t2 = new Thread(() => Prim.Problem2(number,Prim.Alg2));
            t1.Name = "Alg1";
            t2.Name = "Alg2";
            t1.Start();
            t2.Start();

        }


    }
}
