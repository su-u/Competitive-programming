//AC
using System;

namespace ABC003A
{
    class Program
    {
        static void Main(string[] args)
        {
            Double n = Double.Parse(Console.ReadLine());

            Double x = 0.0;
            for(Int32 i = 0;i < n; ++i)
            {
                x += ((i + 1) * 10000) / n;
                //Console.WriteLine(x);
            }

            Int32 a = (Int32)x;
            Console.WriteLine(a);
        }
    }
}
