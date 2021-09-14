using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic058
{
    class GenericcomparetoMethod<T> where T : IComparable
    {
        public T first, second, third;
        public GenericcomparetoMethod(T first, T second, T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }

        public static T MaxNum(T first, T second, T third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            else if (third.CompareTo(second) > 0 && third.CompareTo(first) > 0)
            {
                return third;
            }
            else
            {
                Console.WriteLine("two or more numbers are equal");
                return default;
            }
        }
        public T MaxMethod()
        {
            T max = GenericcomparetoMethod<T>.MaxNum(this.first, this.second, this.third);
            return max;
        }
    }
}
