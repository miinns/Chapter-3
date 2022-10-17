﻿using System;

class StringCompare
{
    public static void Main()
    {
        string a = "ABC";
        string b = "ABCD";
        int c = String.Compare(a, b);
        int c1 = String.Compare(b, a);
        Console.WriteLine("a compate b => result, {0}, {1}", c, c1);
        string d = "ABC";
        string e = "abcd";
        int f = String.Compare(d, e, true);
        int f1 = String.Compare(e, d, true);
        Console.WriteLine("d compate e => result, {0}, {1}", f, f1);
        string d1 = "ABC";
        string e1 = "abc";
        int f2 = String.Compare(d1, e1, true);
        int f3 = String.Compare(e1, d1, true);
        Console.WriteLine("d1 compate e1 => result, {0}, {1}", f2, f3);
    }
}