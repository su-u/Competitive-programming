using System;
using System.Diagnostics;

class Program
{
    private static int Min(int x, int y, int z)
    {
        return Math.Min(Math.Min(x, y), z);
    }

    private static int ComputeLevenshteinDistance(string strX, string strY)
    {
        if (strX == null)
            throw new ArgumentNullException("strX");
        if (strY == null)
            throw new ArgumentNullException("strY");

        if (strX.Length == 0)
            return strY.Length;
        if (strY.Length == 0)
            return strX.Length;

        var d = new int[strX.Length + 1, strY.Length + 1];

        for (var i = 0; i <= strX.Length; i++)
        {
            d[i, 0] = i;
        }
        Console.WriteLine($"X:Init");
        d.Print();

        for (var j = 0; j <= strY.Length; j++)
        {
            d[0, j] = j;
        }
        Console.WriteLine($"Y:Init");
        d.Print();

        for (var j = 1; j <= strY.Length; j++)
        {
            for (var i = 1; i <= strX.Length; i++)
            {
                if (strX[i - 1] == strY[j - 1])
                    d[i, j] = d[i - 1, j - 1];
                else
                    d[i, j] = Min(d[i - 1, j] + 1,
                        d[i, j - 1] + 1,
                        d[i - 1, j - 1] + 1);
                Console.WriteLine($"比較文字{i}:{j} {strX[i - 1]} == {strY[j - 1]}");
                d.Print();
            }
        }


        return d[strX.Length, strY.Length];
    }

    static void Main()
    {
        foreach (var texts in new[] {
            new[] {"あいう", "あい"},
        })
        {
            Console.WriteLine("{0} => {1} : {2}",
                texts[0],
                texts[1],
                ComputeLevenshteinDistance(texts[0], texts[1]));
        }
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