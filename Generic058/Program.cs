using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic058
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 12, 14, 17, 86, 92, 76 };
            GenericcomparetoMethod<int> generic = new GenericcomparetoMethod<int>(arr);
            generic.PrintMaxValue();
            Console.ReadLine();
        }
    }
}
