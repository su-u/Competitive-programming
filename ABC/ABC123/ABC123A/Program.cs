using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using static System.Console;

namespace ABC123A
{
    static class Program
    {
        static void Main(string[] args)
        {
            var l = ReadLineOne<int>(5);
            var k = ReadLine().TryParse<int>();

            string a = l.All(x => l.All(y => Math.Abs(y - x) <= k)) ? "Yay!" : ":(";
            WriteLine(a);
        }

        private static string Check(List<int> l, int k)
        {
            for (int i = 1; i < l.Count; i++)
            {
                for (int j = i + 1; j < l.Count; j++)
                {
                    if (l[j] - l[i] > k) return ":(";

                }

            }

            return "Yay!";
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
