using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ABC002C
{
    class Program
    {
        //未完成
        static void Main(string[] args)
        {
            P("");
        }

        static void P(String s)
        {
            Int32[] x = Console.ReadLine().Split().Select(k => Int32.Parse(s)).ToArray();
            Int32[] a = new Int32[x[1]];
            Int32[] b = new Int32[x[1]];

            for(int i = 0;i < x[1]; ++i)
            {
                var c = Console.ReadLine().Split();
                a[i] = Int32.Parse(c[0]);
                b[i] = Int32.Parse(c[1]);
            }

            var a2 = a.OrderBy(t => -t);
            var b2 = b.OrderBy(t => -t);
        }
    }
}
