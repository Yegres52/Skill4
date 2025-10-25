using System;

class MainClass
{
    public static void Main(string[] args)
    {
        var A = 1;
        var B = 2;
        double X = 5;
        double Y = 4;

        var result = (A < B) | (X > Y);

        Console.WriteLine(result);
        Console.ReadKey();
    }
}
