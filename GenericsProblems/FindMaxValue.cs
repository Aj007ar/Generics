using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblems
{
    internal class FindMaxValue
    {
        public static int MaxIntValue(int number1, int number2, int number3)
        {

            int max = number1.CompareTo(number2) == 1 ? number1 : number2;
            max = max.CompareTo(number3) == 1 ? max : number3;
            Console.WriteLine("The maximum number is {0}", max);
            Console.WriteLine("\n");
            return max;
        }
    }
}
