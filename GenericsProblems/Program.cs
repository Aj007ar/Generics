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
            Console.WriteLine("\n-----------> Max String <-----------------");
            string maxString = FindMaxValue.MaxString("Apple", "Peach", "Banana");
            Console.WriteLine("\n----------------> GENERIC METTHOD <----------------- ");
            int maxInt = GenericMethod.ToPrint(12, 55, 78);
            float maxfloat = GenericMethod.ToPrint(12.1f, 25.1f, 42.2f);
            string maxstring = GenericMethod.ToPrint("Apple", "Peach", "Banana");
            Console.WriteLine("\n-------------> GENERIC CLASS <--------------------");
            int MaxInt = GenericClass<int>.toPrint(12, 55, 78);
            float MaxFloat = GenericClass<float>.toPrint(12.1f, 25.1f, 42.2f);
            string MaxString = GenericClass<string>.toPrint("Apple", "Peach", "Banana");
        }
    }
}