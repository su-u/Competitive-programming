using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ABC004
{
    public static class Class1
    {
        public static void ABC004A()
        {
            Console.WriteLine(Console.ReadLine().TryParse<Int32>() * 2);
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
