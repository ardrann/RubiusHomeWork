using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    internal class Patient
    {
        public string Name;
        public int Age;
        public string Address;
        public string Status;

        public Patient(string name, int age, string address, string status)
        {
            Name = name;
            Age = age;
            Address = address;
            Status = status;
        }
    }
}
