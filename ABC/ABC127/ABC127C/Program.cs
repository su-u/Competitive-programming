using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using static System.Console;

namespace ABC127C
{
    static class Program
    {
        static void Main(string[] args)
        {
            var n = ReadLine().SplitTryParseToList<int>();
            var a = 0;
            var left = new List<int>();
            var right = new List<int>();

            var m = ReadLine().SplitTryParseToList<int>();
            left.Add(m[0]);
            right.Add(m[1]);
            if (n[1] == 1)
            {
                a = right[0] - left[0];
            }
            else
            {
                foreach (var i in Enumerable.Range(1, n[1] - 1))
                {
                    var o = ReadLine().SplitTryParseToList<int>();

                    left.Add(o[0]);
                    right.Add(o[1]);
                }

                var l = left.OrderByDescending(i => i).ToList();
                var r = right.OrderBy(i => i).ToList();
                //l.PrintAll();
                //r.PrintAll();
                a = r[0] - l[0];
                if (a < 0) a = -1;
            }

            a += 1;
            //a.PrintAll();
            //var duplicates = a.GroupBy(name => name).Where(name => name.Count() >= n[1])
            //    .Select(group => group.Key).ToList();
            //duplicates.PrintAll();
            WriteLine(a);

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
