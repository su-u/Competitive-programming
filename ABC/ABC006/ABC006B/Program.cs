using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;


namespace ABC006B
{
    static class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine().TryParse<int>();
            List<long> l = new List<long>() { 0, 0, 1 };
            if (n >= 3)
            {
                foreach (var i in Enumerable.Range(3, n - 3))
                {
                    var a = l[i - 1] + l[i - 2] + l[i - 3];
                    l.Add(a % 10007);
                }
                Console.WriteLine(l[l.Count - 1]);
            }
            else
            {
                Console.WriteLine(l[n - 1]);
            }
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

        /// <summary>
        /// リスト内部の指定した要素同士を交換する。
        /// </summary>
        /// <typeparam name="T">リストの型</typeparam>
        /// <param name="list">交換する対象のリスト</param>
        /// <param name="index1">交換する要素番号</param>
        /// <param name="index2">交換する要素番号</param>
        /// <returns></returns>
        public static List<T> ListSwap<T>(this List<T> list, Int32 index1, Int32 index2)
        {
            var t = list[index1];
            list[index1] = list[index2];
            list[index2] = t;
            return list;
        }
    }
}
