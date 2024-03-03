using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8.Task1
{
    internal class Counter
    {
        public delegate void MyDelegate();
        public event MyDelegate Counting;

        public void Count()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
                if (i == 77)
                {
                    Counting.Invoke();
                }
            }
        }
    }
}
