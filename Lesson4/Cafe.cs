using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4;
public class Cafe
{
    public string name;
    public int rating;
    public string? cousine;
    public List<Visitor> visitors = new List<Visitor>();


    public Cafe(string cafeName)
    {
        name = cafeName;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Кафе с названием {name}, рейтинг: {rating}, кухня: {cousine}");
    }

    public void AddVisitor( Visitor visitor )
    { 
        visitors.Add( visitor );
        Console.WriteLine($"В кафе \"{name}\" пришел посетитель {visitor.name}");
    }

    public void MakeOrder( Visitor visitor ) 
    { 
        Console.WriteLine($"Посетитель {visitor.name} заказал блюдо \"{visitor.favouriteMeal}\"");
    }
}
