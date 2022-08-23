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
        public static string MaxString(string s1,string s2,string s3)
        {
            string maxString = s1.CompareTo(s2) == 1 ? s1 : s2;
            maxString = maxString.CompareTo(s3) == 1 ? maxString : s3;
            Console.WriteLine("Max String is {0}",maxString);
            return maxString;
        }
    }
}
