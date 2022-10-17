using System;
class Foreach
{
    public static void Main()
    {
        string[] color = { "pink", "blue", "yellow" };
        foreach (string s in color)
            Console.WriteLine(s);
    }
}