namespace Lesson4;

public class Program
{
    public static void Main()
    {
        var pizzeria = new Cafe("Фигаро")
        {
            rating = 4,
            cousine = "итальянская"
        };

        pizzeria.ShowInfo();

        var John = new Visitor("Джон", 25, pizzeria, "паста Карбонара");
        var Mary = new Visitor("Мэри", 22, pizzeria, "пицца Маргарита");

        pizzeria.AddVisitor(John);
        pizzeria.MakeOrder(John);
        pizzeria.AddVisitor(Mary);
        pizzeria.MakeOrder(Mary);
    }
}