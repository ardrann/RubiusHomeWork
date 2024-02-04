namespace Lesson2;

public class Program
{
    public static void Main()
    {
        
        var input_number = Console.ReadLine();

        var number = int.Parse(input_number);

        if (number % 400 == 0)
        { 
            Console.WriteLine("YES"); 
        }
        else if (number % 4 == 0 && number % 100 != 0)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }

    }
}