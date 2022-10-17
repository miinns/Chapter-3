using System;
using System.Net.Http;

class ContinueSt
{
    public static void Main()
    {
        int a, b, sum;
        Console.Write("Enter a number ");
        for (;;)
        {
            a = Console.Read() - '0';
            if (a == 0) break;
            else if (a < 0) continue;
            for (b = 0, sum = 1; sum <= a; ++sum)
                b += sum;
            Console.WriteLine("a = {0}, sum = {1}", a, b);
        }
        Console.WriteLine("Main of main");
    }
}