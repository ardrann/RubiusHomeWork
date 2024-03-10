using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lesson5
{
    internal class Doctor
    {
        public int Experience;
        public string Name;
        public string Specialization;
        public int Age;

        public Doctor(int experience, string name, string specialization, int age)
        {
            Experience = experience;
            Name = name;
            Specialization = specialization;
            if (age < 20) 
            {
                throw new Exception("Возраст должен быть больше 20 лет");
            }
            Age = age;
        }

        public void Cure(Patient patient) 
        {
            Console.WriteLine($"Пациент {patient.Name} находится на лечении у врача-{Specialization}а.");
            patient.Status = "Здоров";
        }
    }
}
