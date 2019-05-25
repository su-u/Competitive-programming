using System;
using System.Linq;
using CPL.Input;
using System.Collections.Generic;
using System.ComponentModel;
namespace ABC003C
{
    class Program
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
    }



    static class Input
    {
        /// <summary>
        /// 文字列を任意の型にキャストする。
        /// </summary>
        /// <typeparam name="T">変換後の型</typeparam>
        /// <param name="input">変換する文字列</param>
        /// <returns>キャストされた値</returns>
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