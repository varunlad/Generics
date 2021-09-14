using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic058
{
    class GenericcomparetoMethod<T> where T : IComparable
    {
        public T[] value;
        public GenericcomparetoMethod(T[] value)
        {
            this.value = value;
        }
        public T[] sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        public T MaxValue(params T[] values)
        {
            T[] sortedArray = sort(this.value);
            return sortedArray[sortedArray.Length - 1];
        }
        public T MaxMethod()
        {
            var max = MaxValue(this.value);
            return max;
        }
        public  void PrintMaxValue()
        {
            var max = MaxValue(this.value);
            Console.WriteLine("The maximum value is : "+max);
        }
    }
}
