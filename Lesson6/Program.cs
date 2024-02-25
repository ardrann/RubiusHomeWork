namespace Lesson6;

public class Program
{
    public static void Main()
    {
        var IntStack = new Stack<int>();
        var StrStack = new Stack<string>();
        var DoubleStack = new Stack<double>();

        IntStack.Push(1);
        IntStack.Push(2);
        IntStack.Push(3);
        IntStack.Push(4);
        IntStack.Push(5);

        Console.WriteLine(IntStack);
        Console.WriteLine(IntStack.IsEmpty());
        Console.WriteLine(IntStack.Pop());
        Console.WriteLine(IntStack);
        Console.WriteLine();

        StrStack.Push("Hello");
        StrStack.Push("Hi");

        Console.WriteLine(StrStack);
        Console.WriteLine(StrStack.Peek());
        Console.WriteLine(StrStack);
        Console.WriteLine();

        DoubleStack.Push(1.1);
        DoubleStack.Push(2.5);

        Console.WriteLine(DoubleStack);
        DoubleStack.Clear();
        DoubleStack.Pop();
    }
}