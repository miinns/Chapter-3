﻿using System;
class For
{
    public static void Main()
    {
        int i, n;
        double h = 0.0;
        Console.Write("Enter a number : ");
        n = Console.Read() - '0';
        for (i = 1; i <= n; i++)
            h = h + 1 / (double) i;
        Console.WriteLine("n = {0}, h = {1}", n, h);
    }
}