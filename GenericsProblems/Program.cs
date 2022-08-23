namespace GenericsProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO GENERIC PROBLEMS");
            Console.WriteLine("---------------> Max Integer <---------------");
            int max = FindMaxValue.MaxIntValue(45, 25, 55);
            Console.WriteLine("\n----------------> Max Float Value <--------------");
            float maxFloat = FindMaxValue.MaxFloatValue(14.2f, 15.2f, 43.2f);
        }
    }
}