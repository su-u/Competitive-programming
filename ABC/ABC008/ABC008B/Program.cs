using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using static System.Console;

namespace ABC008B
{
    static class Program
    {
        static void Main(string[] args)
        {
            var n = ReadLine().TryParse<int>();
            List<string> list = new List<string>();
            foreach(var i in Enumerable.Range(1, n)) {
                list.Add(ReadLine().TryParse<string>());
            }

            List<string> alist = new List<string>() { "b", "1", "b"};
                .ToList();
            var duplicationList = list.DuplicateCount();

            var hogehoge = duplicationList.OrderByDescending((x) => x.Item2);            

            WriteLine(hogehoge.First().Item1);

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
                throw new InvalidCastException(typeof(T) + " is not suported.");
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

        public static List<Tuple<T, int>> DuplicateCount<T>(this List<T> list)
        {
            return list
                .GroupBy(i => i)
                .Where(g => g.Count() >= 1)
                .Select(g => Tuple.Create(g.Key, g.Count()))
                .ToList();
        }
    }
}
