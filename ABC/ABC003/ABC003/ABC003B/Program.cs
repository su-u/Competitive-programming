using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC003B
{
    static class Program
    {
        static void Main(string[] args)
        {
            var change = new Char[]{ 'a', 't', 'c', 'o', 'd', 'e', 'r', '@'};
            String s = Console.ReadLine();
            String t = Console.ReadLine();

            Boolean jg = true;
            String at = "";

            for(Int32 i = 0;i < s.Length; ++i)
            {
                if(s[i] != t[i])
                {
                    if(s[i] == '@')
                    {
                        if(change.Any(n => n == t[i]))
                        {
                            //s[i] = t[i];
                            s = ChangeCharAt(s, i, t[i]);
                            //Console.WriteLine(s);
                        }
                        else
                        {
                            jg = false;
                        }
                    }else if(t[i] == '@')
                    {
                        if (change.Any(n => n == s[i]))
                        {
                            //s[i] = t[i];
                            t = ChangeCharAt(t, i, s[i]);
                            //Console.WriteLine(t);
                        }
                        else
                        {
                            jg = false;
                        }
                    }
                    else
                    {
                        jg = false;
                    }
                }
            }

            if (jg)
            {
                Console.WriteLine("You can win");
            }
            else
            {
                Console.WriteLine("You will lose");
            }

            

        }
        static string ChangeCharAt(this string str, int index, char newChar)
        {
            return str.Remove(index, 1).Insert(index, newChar.ToString());
        }

    }
}
