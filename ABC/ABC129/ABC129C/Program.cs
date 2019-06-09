using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using static System.Console;

namespace ABC129C
{
    static class Program
    {
        static void Main(string[] args)
        {
            var line = ReadLine().SplitTryParseToList<int>();

            var list = ReadLineOne<int>(line[1]);



            var g = list.Select((x, index) => new {x, index})
                .GroupBy(e => e.x - e.index, e => e.x).Max(x => x.Count());



            long count = 0;
            if (g >= 2)
            {
                WriteLine(0);
            }
            else
            {
                count = pow(2, line[0] - 3, 1000000007);
                long waru = (long)Math.Pow(2, list.Count);
                count = count / waru;


                WriteLine(count % 1000000007);
            }
        }

        static public long pow(long a, long b, long c)
        {
            long re = 1;
            for (int i = 1; i <= b; i++)
            {
                re = re * a % c;
            }

            return re;
        }


        public static T TryParse<T>(this String input)
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
                throw new InvalidCastException(typeof(T) + " is not supported.");
            }
        }

        public static List<T> SplitTryParseToList<T>(this String input)
        {
            return input.Split().Select(n => n.TryParse<T>()).ToList();
        }

        public static List<T> ListSwap<T>(this List<T> list, Int32 index1, Int32 index2)
        {
            var t = list[index1];
            list[index1] = list[index2];
            list[index2] = t;
            return list;
        }

        public static List<Tuple<T, int>> DuplicateCount<T>(this IEnumerable<T> list)
        {
            return list
                .GroupBy(i => i)
                .Where(g => g.Any())
                .Select(g => Tuple.Create(g.Key, g.Count()))
                .ToList();
        }
        public static List<Tuple<T, int>> DuplicateSort<T>(this IEnumerable<Tuple<T, int>> list)
        {
            return list.OrderByDescending((x) => x.Item2).ToList();
        }
        public static List<T> ReadLineOne<T>(int n)
        {
            var list = new List<T>();
            foreach (var i in Enumerable.Range(1, n))
            {
                list.Add(Console.ReadLine().TryParse<T>());
            }
            return list;
        }
        public static void PrintAll<T>(this IEnumerable<T> list)
        {
            foreach (var i in list)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }
    }
}
