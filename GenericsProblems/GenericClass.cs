using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblems
{
    internal class GenericClass<T> where T : notnull, IComparable<T>
    {
        public static T toPrint(T v1, T v2, T v3) 
        {

            T Max = v1.CompareTo(v2) == 1 ? v1 : v2;
            Max = Max.CompareTo(v3) == 1 ? Max : v3;
            Console.WriteLine("Maximum is {0}", Max);
            return Max;
        }
    }
}
