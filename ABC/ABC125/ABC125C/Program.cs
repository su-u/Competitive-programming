using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ABC125C
{
    class Program
    {
        static void Main(string[] args)
        {

            Int32[] x = Console.ReadLine().Split().Select(s => Int32.Parse(s)).ToArray();

            Console.WriteLine(x[1] / x[0]);



        }
    }
}
