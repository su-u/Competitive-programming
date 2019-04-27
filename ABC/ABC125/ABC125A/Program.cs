using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ABC125A
{
    class Program
    {
        static void Main(string[] args)
        {

            Double[] x = Console.ReadLine().Split().Select(s => Double.Parse(s)).ToArray();

            Console.WriteLine(Math.Abs(((x[0] - x[4]) * (x[3] - x[5]) - (x[2] - x[4]) * (x[1] - x[5])) * 0.5));



        }
    }
}
