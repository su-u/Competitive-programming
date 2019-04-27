using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ABC125B
{
    class Program
    {
        static void Main(string[] args)
        {

            Int32 n = Int32.Parse(Console.ReadLine());

            Int32[] v = Console.ReadLine().Split().Select(s => Int32.Parse(s)).ToArray();
            Int32[] c = Console.ReadLine().Split().Select(s => Int32.Parse(s)).ToArray();

            Int32 a = 0;
            for(Int32 i = 0;i < n; ++i)
            {
                if(v[i] / c[i] >= 1)
                {
                    a += v[i] - c[i];
                }
            }



            Console.WriteLine(a);



        }
    }
}
