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
            return max;
        }
        public static float MaxFloatValue(float number1, float number2, float number3)
        {
            float maxFloat = number1.CompareTo(number2) == 1 ? number1 : number2;
            maxFloat = maxFloat.CompareTo(number3) == 1 ? maxFloat : number3;
            Console.WriteLine("Maximum number is {0}",maxFloat);
            return maxFloat;
        }
    }
}
