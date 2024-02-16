using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4;
public class Visitor
{
    public string name;
    public int age;
    public Cafe cafe;
    public string favouriteMeal;

    public Visitor(string visitorName, int visitorAge, Cafe visitorCafe, string visitorMeal)
    {
        name = visitorName;
        age = visitorAge;
        cafe = visitorCafe;
        favouriteMeal = visitorMeal;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Посетитель с именем {name}, возраст: {age}");
    }
}
