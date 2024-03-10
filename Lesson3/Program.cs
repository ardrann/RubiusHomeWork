namespace Lesson3;

public class Program
{
    public static void Main()
    {

        // запросить у пользователя размер массива

        Console.WriteLine("Введите длину массива");
        string answer = Console.ReadLine();
        if (!int.TryParse(answer, out int length))
        {
            Console.WriteLine("Вам необходимо ввести число");
        }

        // запросить у пользователя элементы массива

        int[] array = new int [length];
        
        for (int i = 0; i < length; i++) 
        {
            Console.WriteLine("Введите элемент массива");
            string new_item = Console.ReadLine();
            if (int.TryParse(new_item, out int int_item))
            {
                array[i] = int_item;
            }
            else
            {
                Console.WriteLine("Вам необходимо ввести число");
            }
            
        }
        foreach (var item in array)
            Console.Write($"{item} ");

        // найти второе наибольшее число

        Array.Sort(array);

        for (int i = length - 1;  i > 0; i--) 
        {
            if (array[i] == array[i-1])
            {
                continue;
            }
            else
            {
                Console.WriteLine(array[i-1]);
                break;
            }
        }


    }
}