namespace Lesson8.Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();
            Handler1 handler1 = new Handler1();
            Handler2 handler2 = new Handler2();

            counter.Counting += handler1.Message;
            counter.Counting += handler2.Message;

            counter.Count();
        }
    }
}