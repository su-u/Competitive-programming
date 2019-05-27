using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ABC005B
{
    static class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine().TryParse<int>();
            List<int> list = new List<int>();
            foreach(var i in Enumerable.Range(0, n))
            {
                list.Add(Console.ReadLine().TryParse<int>());
            }
            list.Sort();
            Console.WriteLine(list[0]);
        }

        /// <summary>
        /// 文字列を任意の型にキャストする。
        /// </summary>
        /// <typeparam name="T">変換後の型</typeparam>
        /// <param name="input">変換する文字列</param>
        /// <returns>キャストされた値</returns>
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

        /// <summary>
        /// 文字列を空白で区切り、任意の型にキャストしたリストに変換する。
        /// </summary>
        /// <typeparam name="T">変換後の型</typeparam>
        /// <param name="input">変換する文字列</param>
        /// <returns>キャストされた値のリスト</returns>
        public static List<T> SplitTryParseToList<T>(this String input)
        {
            return input.Split().Select(n => n.TryParse<T>()).ToList();
        }
    }
}
