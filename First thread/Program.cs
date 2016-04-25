using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace First_thread
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print();
            //Print();
            //Print();
            //Print();

            Thread t1 = new Thread(() => Print("First", 10));
            Thread t2 = new Thread(() => Print("Second", 10));
            Thread t3 = new Thread(() => Print("Third", 10));
            Thread t4 = new Thread(() => Print("Fourth", 10));

            t1.Name = "My first thread";
            t2.Name = "My second thread";
            t3.Name = "My third thread";
            t4.Name = "My fourth thread";

            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();

        }

        static void Print(string message, int numberOfTimes)
        {
            for (int i = 0; i < numberOfTimes; i++)
            {
                Console.WriteLine("{0}, {1}", message, Thread.CurrentThread.Name);              
            }
        }

        //TODO try out the Sleep method and the rest of Lab_First thread
    }
}
