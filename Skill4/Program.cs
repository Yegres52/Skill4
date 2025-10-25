using System;

class MainClass
{
    public static void Main(string[] args)
    {

        var a = 5 + 6;
        var b = 7 + 8;

        var c = (b == a) & (b > a + 1);
        var d = (b == a) && (b > a + 1);

        Console.WriteLine(c);
        Console.WriteLine(d);
        Console.ReadKey();

    }
}
