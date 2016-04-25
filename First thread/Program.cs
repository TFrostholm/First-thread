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

            Thread t1 = new Thread(() => Print("Hello", 10, 2));
            Thread t2 = new Thread(() => Print("everybody!", 10, 10));
            Thread t3 = new Thread(() => Print("What's", 10, 1000));
            Thread t4 = new Thread(() => Print("up?", 10, 1500));

            t1.Name = "1";
            t2.Name = "2";
            t3.Name = "3";
            t4.Name = "4";

            t1.Priority = ThreadPriority.Lowest;
            t2.Priority = ThreadPriority.BelowNormal;
            t3.Priority = ThreadPriority.Highest;
            t4.Priority = ThreadPriority.Normal;

            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();

            t1.Join();
            t2.Join();
            t3.Join();
            t4.Join();

            Console.WriteLine("\nThis is it");

            //Not working correctly - didn't fully understand whis Pooling thing
            Task.Run(() => Print("Pool", 2, 1));
            Console.ReadLine();

        }

        static void Print(string message, int numberOfTimes, int sleepTime)
        {
            for (int i = 0; i < numberOfTimes; i++)
            {
                Console.WriteLine("Message: {0}, Thread number: {1} has it's priority set to {2}", message, Thread.CurrentThread.Name, Thread.CurrentThread.Priority);
                Thread.Sleep(sleepTime);              
            }
        }
    }
}
