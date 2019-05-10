using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC003B
{
    class Program
    {

        static void Main(string[] args)
        {
            var change = new Char[]{ 'a', 't', 'c', 'o', 'd', 'e', 'r'};
            String s = Console.ReadLine();
            String t = Console.ReadLine();

            Boolean jg = false;

            foreach(Char i in s)
            {
                foreach(Char j in t)
                {
                    if (i != j) jg = false;
                    if(i == '@')
                    {
                        if(change.Any(n => n == j))
                        {
                           
                        }
                    }
                }
            }

        }
    }
}
