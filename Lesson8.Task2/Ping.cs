using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8.Task2
{
    internal class Ping
    {
        delegate void MyDelegate();

        public static void Play()
        {
            MyDelegate DoPong = Pong.Play;

            Random sequence = new Random();
            int result = sequence.Next(0, 10);

            if (result != 0)
            {
                Console.WriteLine("Pong получил Ping");
                DoPong();
            }
            else
            {
                Console.WriteLine("Ping промахнулся! Победил Pong");
            }
        }
    }
}
