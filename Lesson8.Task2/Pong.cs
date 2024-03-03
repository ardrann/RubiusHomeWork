using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8.Task2
{
    internal class Pong
    {
        delegate void MyDelegate();

        public static void Play()
        {
            MyDelegate DoPing = Ping.Play;

            Random sequence = new Random();
            int result = sequence.Next(0, 10);

            if (result != 0)
            {
                Console.WriteLine("Ping получил Pong");
                DoPing();
            }
            else
            {
                Console.WriteLine("Pong промахнулся! Победил Ping");
            }
        }
    }
}
