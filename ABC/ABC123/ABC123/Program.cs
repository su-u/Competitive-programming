using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Text.RegularExpressions;

class Program
{
    private static int Min(int x, int y, int z)
    {
        return Math.Min(Math.Min(x, y), z);
    }

    private static int ComputeLevenshteinDistance(string str1, string str2)
    {
        if (str1 == null)
            throw new ArgumentNullException("str1");
        if (str2 == null)
            throw new ArgumentNullException("str2");

        if (str1.Length == 0)
            return str2.Length;
        if (str2.Length == 0)
            return str1.Length;

        var d = new int[str1.Length + 1, str2.Length + 1];

        for (var i = 0; i <= str1.Length; i++)
        {
            d[i, 0] = i;
        }

        for (var j = 0; j <= str2.Length; j++)
        {
            d[0, j] = j;
        }

        for (var j = 1; j <= str2.Length; j++)
        {
            for (var i = 1; i <= str1.Length; i++)
            {
                if (str1[i - 1] == str2[j - 1])
                    d[i, j] = d[i - 1, j - 1];
                else
                    d[i, j] = Min(d[i - 1, j] + 1,
                        d[i, j - 1] + 1,
                        d[i - 1, j - 1] + 1);
            }
        }


        return d[str1.Length, str2.Length];
    }

    static int Main(string[] args)
    {
        bool result1 = false;
        bool result2 = false;
        if (args.Length == 0)
        {
            Console.WriteLine("0");
            return 0;
        }
        else if (args.Length < 2)
        {
            Console.WriteLine($"{args[0].Length}");
            return 0;
        }
        else if (args.Length == 2)
        {
            result1 = Regex.IsMatch(args[0], "[A-Za-z0-9]");
            result2 = Regex.IsMatch(args[1], "[A-Za-z0-9]");
            Console.WriteLine($"{ComputeLevenshteinDistance(args[0], args[1])}");
        }
        else if (args.Length >= 3)
        {
            return 1;
        }

        if (!result1 || !result2) return 1;

        return 0;
    }

}

public static class MyEx
{
    public static void Print(this int[,] d)
    {
        int x = d.GetLength(0);
        int y = d.GetLength(1);
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                Console.Write($"{d[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}