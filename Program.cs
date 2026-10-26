using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Nhap n = ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("n phai > 0");
            return;
        }

        List<int> ds = new List<int>();
        Random rnd = new Random();

        // Phat sinh ngau nhien
        for (int i = 0; i < n; i++)
        {
            ds.Add(rnd.Next(100)); // so tu 0 -> 99
        }

        Console.WriteLine("\nDay vua tao:");
        foreach (int x in ds)
        {
            Console.Write(x + " ");
        }

        // Sap xep tang dan
        ds.Sort();

        Console.WriteLine("\n\nDay sau khi sap xep:");
        foreach (int x in ds)
        {
            Console.Write(x + " ");
        }
    }
}