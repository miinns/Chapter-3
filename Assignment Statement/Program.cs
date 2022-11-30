using System;
class Assignment
{
    public static void Main()
    {
        short s;
        int i;
        float f;
        double d;
        s = 526; // 맨 우측에서 좌로
        d = f = i = s;
        Console.WriteLine("s = " + s + " i = " + i);
        Console.WriteLine("f = " + f + " d = " + d);
    }
}
