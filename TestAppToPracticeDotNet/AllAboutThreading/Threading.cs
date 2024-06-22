using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppToPracticeDotNet.AllAboutThreading
{
    public class Threading
    {
        public Threading()
        {
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Threaad";
            //Console.WriteLine(mainThread.Name);

            /* TASK
             * Having two thread containing two timers
             * Forward timer -> Count from 0-10
             * Backward timer -> Count from 10-0
             * Both concurrently in multithread at the same time
             */

            /*CountUp();
            CountDown();*/

            Thread countUpThread = new Thread(CountUp);
            Thread countDownThread = new Thread(CountDown);
            countUpThread.Start();
            countDownThread.Start();
            Console.WriteLine(mainThread.Name + " is complete!");
        }

        // static method can be called from outside without declaring an instance of the class
        public static void CountUp()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Timer #1: " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #1 is completed!");
        }


        public static void CountDown()
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Timer #2: " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #2 is completed!");
        }
    }
}
