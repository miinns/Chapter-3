using System;
class ifSt
{
    public static void Main()
    {
        int n;
        Console.Write("Enter a number = ");
        n = Console.Read() - '0'; // '0' : 문자 
        if (n % 2 == 0) // 짝수
            Console.WriteLine(n + " is an even number.");
        else // 홀수
            Console.WriteLine(n + " is an odd number.");
    }
}