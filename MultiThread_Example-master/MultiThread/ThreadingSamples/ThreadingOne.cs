using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThread.ThreadingSamples
{
    internal class ThreadingOne
    {
        public static void DemoThread()
        {
            Thread sampleThread1 = new Thread(new ThreadStart(SampleThread1));
            sampleThread1.Start();

            Thread sampleThread2 = new Thread(new ThreadStart(SampleThread2));
            sampleThread2.Start();

            Console.ReadKey();
            sampleThread1.Abort();
            sampleThread2.Abort();
        }

        static void SampleThread1()
        {
            while (true)
            {
                Console.WriteLine("ONE ONE ONE ONE");
                Thread.Sleep(500);
            }
        }

        static void SampleThread2()
        {
            while (true)
            {
                Console.WriteLine("TWO TWO TWO TWO TWO");
                Thread.Sleep(1200);
            }
        }

    }
}
