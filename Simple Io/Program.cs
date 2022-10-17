using System;
class IO {
    public static void Main()
    {
        int a;
        char b;
        Console.Write("Enter a digit a character : ");
        a = Console.Read() - 48; // 문자 코드 값
        b = (char)Console.Read();
        Console.WriteLine("a = {0}, b = {1}", a, b);
    }
}