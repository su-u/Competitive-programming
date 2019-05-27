using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ABC004C
{
    static class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine().TryParse<int>();
            var list = new List<int>() { 1, 2, 3, 4, 5, 6 };

            n = n % 30;

            foreach(var i in Enumerable.Range(0, n))
            {
                var a = i % 5;
                var b = i % 5 + 1;
                //Console.WriteLine($"{i}:{a},{b}");
                var t = list[b];
                list[b] = list[a];
                list[a] = t;
            }

            foreach(var i in list)
            {
                Console.Write(i);
            }
            Console.WriteLine();
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

        /// <summary>
        /// 文字列を空白で区切り、任意の型にキャストしたリストに変換する。
        /// </summary>
        /// <typeparam name="T">変換後の型</typeparam>
        /// <param name="input">変換する文字列</param>
        /// <returns>キャストされた値のリスト</returns>
        public static List<T> SplitTryParseToList<T>(this string input)
        {
            return input.Split().Select(n => n.TryParse<T>()).ToList();
        }
    }
}
