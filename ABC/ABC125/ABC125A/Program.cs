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

            Double a = 0;
            
            for(Double i = x[0]; i < x[2] + 0.5; i += x[0])
            {
                a += x[1];
            }

   
            Console.WriteLine((double)a);


        }
    }
}
