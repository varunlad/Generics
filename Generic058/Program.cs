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
            Console.WriteLine("The maximum number is:{0}", GenericcomparetoMethod<string>.MaxNum("varun", "hemant", "lad"));
            Console.ReadLine();
        }
    }
}
