using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
namespace ABC003C
{
    static class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine().SplitTryParseToList<int>();
            var r = Console.ReadLine().SplitTryParseToList<Double>();

            r.Sort();

            //foreach (var j in r)
            //{
            //    Console.Write($"{j} ");
            //}
            //Console.WriteLine();

            r.RemoveRange(0, r.Count - n[1]);

            //foreach(var j in r)
            //{
            //    Console.Write($"{j} ");
            //}
            //Console.WriteLine();


            Double rate = 0.0;

            foreach (var i in Enumerable.Range(0, n[1]))
            {

                rate = (rate + r[i]) / 2.0;

            }

            Console.WriteLine(rate.ToString("F8"));
        }
        public static T TryParse<T>(this string input)
        {
            try
            {
                var converter = TypeDescriptor.GetConverter(typeof(T));
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