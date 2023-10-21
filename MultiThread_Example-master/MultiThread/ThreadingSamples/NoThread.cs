using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Threading;

namespace MultiThread.ThreadingSamples
{
    internal class NoThread
    {
        public static void NoThreadExample()
        {
            NoThread1();
            NoThread2();    
        }

        static void NoThread1()
        {
            while (true)
            {
                Console.WriteLine("First Thread Here... Yo");
                Thread.Sleep(500);
            }
        }

        static void NoThread2()
        {
            while (true)
            {
                Console.WriteLine("This is the secondy dippity one.");
                Thread.Sleep(500);
            }
        }
    }

}
