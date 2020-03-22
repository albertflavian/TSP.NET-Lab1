using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Lab1_threadsAndEvents
{
    public class Prim
    {
        static public bool IsPrim1(int n)
        {
            if (n > 1)
            {
                if (n % 2 == 0)
                    return false;
                if (n % 3 == 0)
                    return false;
                if (n % 5 == 0)
                    return false;
                for (int i = 7; i <= n / 2; i += 2)
                    if (n % i == 0)
                        return false;
            }
            return true;
        }
        static public int Alg1(int n)
        {
            
            int tmp;
            if ((n - 1) % 2 == 0)
                tmp = n - 2;
            else
                tmp = n - 1;
            for (int i = tmp; i >= 2; i -= 2)
            {
                if (IsPrim1(i))
                    return i;
                Thread.Sleep(100);
            }
            return 1;
        }

        static public int Alg2(int n)
        {
         
            for (int i = n - 1; i >= 1; i--)
            {
                Thread.Sleep(100);
                bool prim = true;
                for (int j = i / 2; j > 1; j--)
                    if (i % j == 0)
                        prim = false;
                if (prim)
                    return i;
            }
            return 1;
        }

        static public void Problem2(int number, Func<int,int> Alg)
        {
            Console.WriteLine($"Start fir: {Thread.CurrentThread.Name} at {DateTime.Now} Input: {number}");
            int prim = Alg(number);
            // iesire temporara din fir
            // cu event si delegate
            Console.WriteLine($"End fir: {Thread.CurrentThread.Name} at {DateTime.Now} Result: {prim}");
        }
    



    }
}
