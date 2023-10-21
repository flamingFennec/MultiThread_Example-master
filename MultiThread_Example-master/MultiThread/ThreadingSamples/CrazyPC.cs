using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MultiThread.ThreadingSamples
{
    internal class CrazyPC
    {
        public static Random _random = new Random();
        public static void CrazyFunctionCall()
        {
            //int my_random_number = _random.Next(0, 100);
            //Console.WriteLine(my_random_number);
            //Console.ReadLine();
            CrazyMouseThread();
            CrazyTextThread();
        }
        static void CrazyMouseThread()
        {
            int moveX = 0;
            int moveY = 0;
            while (true)
            {
                moveX = _random.Next(20)-10;
                Console.WriteLine(moveX);
                moveY = _random.Next(20)-10;
                Console.WriteLine(moveY);
                
                Cursor.Position = new System.Drawing.Point(Cursor.Position.X + moveX, Cursor.Position.Y + moveY);
                Thread.Sleep(100);
            }
        }
        static void CrazyTextThread()
        {
            while (true)
            {
                string randomText = GenerateRandomTextInput(_random, 10); // Change 10 to the desired text length
                SendKeys.SendWait(randomText);
                Thread.Sleep(1000); // Adjust the delay between text inputs as needed
            }
        }

        static string GenerateRandomTextInput(Random random, int length)
        {
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            char[] randomChars = new char[length];
            for (int i = 0; i < length; i++)
            {
                randomChars[i] = characters[random.Next(0, characters.Length)];
            }
            return new string(randomChars);
        }
    }
}
