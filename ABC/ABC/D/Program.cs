﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using static System.Math;
using static System.Console;

using static CPL.Input.IO;
using static CPL.Input.InputEx;
using static CPL.String.StringEx;
using static CPL.Collections.CollectionsEx;

namespace D
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
}


namespace CPL
{
    namespace Input
    {
        public static class IO
        {
            public static T RL<T>()
            {
                var line = ReadLine() ?? throw new Exception();
                return line.Trim().TryParse<T>();
            }

            public static List<T> RLL<T>()
            {
                return ReadLine().TrySplitParseToList<T>();
            }

            public static void WL<T>(T s)
            {
                WriteLine(s);
            }
        }

        public static class InputEx
        {

            public static T TryParse<T>(this string input)
            {
                try
                {
                    var converter = TypeDescriptor.GetConverter(typeof(T));
                    return (T)converter.ConvertFromString(input);
                }
                catch
                {
                    throw new InvalidCastException(typeof(T) + " is not supported.");
                }
            }

            public static List<T> TrySplitParseToList<T>(this string input, char separator = ' ')
            {
                return input.Split(separator).Select(TryParse<T>).ToList();
            }

            public static List<T> ReadLineOne<T>(int n)
            {
                return Enumerable.Range(1, n).Select(i => Console.ReadLine().TryParse<T>()).ToList();
            }
            
            public static List<TResult> ReadLineMulti<TSource, TResult>(int n, Func<TResult> func)
            {
                return Enumerable.Range(1, n).Select(i => func()).ToList();
            }
        }
    }

    namespace Collections
    {
        public static class CollectionsEx
        {
            public static List<Tuple<T, int>> DuplicateCount<T>(this IEnumerable<T> list)
            {
                return list
                    .GroupBy(i => i)
                    .Select(g => Tuple.Create(g.Key, g.Count()))
                    .ToList();
            }

            public static List<Tuple<T, int>> DuplicateOrderByDescending<T>(this IEnumerable<Tuple<T, int>> list)
            {
                return list.OrderByDescending(x => x.Item2).ToList();
            }

            public static List<T> ListSwap<T>(this List<T> list, int index1, int index2)
            {
                var t = list[index1];
                list[index1] = list[index2];
                list[index2] = t;
                return list;
            }

            public static void PrintAll<T>(this IEnumerable<T> list)
            {
                foreach (var i in list)
                {
                    Write($"{i} ");
                }
            }
        }
    }

    namespace String
    {
        public static class StringEx
        {
            public static string Reversed(this string s)
            {
                return string.Join("", s.Reverse());
            }
        }
    }
}
