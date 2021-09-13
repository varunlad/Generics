using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic058
{
    class CompareMethod
    {
        public static string MaxNumber(string first, string second, string third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0) //condition 1
            {
                return first;
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)//condition 2
            {
                return second;
            }
            else if (third.CompareTo(second) > 0 && third.CompareTo(first) > 0)//condition 3
            {
                return third;
            }
            else
            {
                Console.WriteLine("Tow or more numbers are Same");
                return null;         
            }

        }
    }
}
