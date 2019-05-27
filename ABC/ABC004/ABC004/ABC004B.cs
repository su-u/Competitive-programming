using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ABC004.B
{
    static class Class2
    {
        public static void Main()
        {
            var l = new List<List<String>>();
            l.Add(Console.ReadLine().SplitTryParseToList<String>());
            l.Add(Console.ReadLine().SplitTryParseToList<String>());
            l.Add(Console.ReadLine().SplitTryParseToList<String>());
            l.Add(Console.ReadLine().SplitTryParseToList<String>());

            foreach(var i in Enumerable.Range(0, 4))
            {
                l[i].Reverse();
            }
            l.Reverse();

            foreach (var i in Enumerable.Range(0, 4))
            {
                foreach(var j in Enumerable.Range(0,l[i].Count))
                {
                    Console.Write($"{l[i][j]} ");
                }
                Console.WriteLine();
            }

        }
        
        public static T TryParse<T>(this string input)
        {
            try
            {
                var converter = System.ComponentModel.TypeDescriptor.GetConverter(typeof(T));
                if (converter != null)
                {
                    return (T)converter.ConvertFromString(input);
                }
                else
                {
                    throw new InvalidCastException("");
                }
            }
            catch
            {
                throw new InvalidCastException(typeof(T) + " is not suported.");
            }
        }

        public static List<T> SplitTryParseToList<T>(this string input)
        {
            return input.Split().Select(n => n.TryParse<T>()).ToList();
        }
    }
}
