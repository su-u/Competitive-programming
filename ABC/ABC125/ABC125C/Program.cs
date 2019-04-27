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

            Int32 n = Int32.Parse(Console.ReadLine());

            Int32[] v = Console.ReadLine().Split().Select(s => Int32.Parse(s)).ToArray();


            Array.Sort(v);

            Int32 a = 0;
            int o = 1;

            if (n == 2)
            {
                    a = v[0];
            }
            else
            {
                for (int i = 0; i < n - 1; ++i) {
                    int cou = 0;
                    a = Gcd(v[i], v[n - 1]);
                    if (a == 1)
                    {
                        break;
                    }
                    for(int j = 0;j < n; ++j)
                    {
                        if (v[j] % a == 0) cou++;
                    }
                    if (cou >= 2)
                    {
                        o++;
                        break;
                    }
                }
            }


            Console.WriteLine(a);

            

        }
        public static int Gcd(int a, int b)
        {
            if (a < b)
                // 引数を入替えて自分を呼び出す
                return Gcd(b, a);
            while (b != 0)
            {
                var remainder = a % b;
                a = b;
                b = remainder;
            }
            return a;
        }
    }
}
