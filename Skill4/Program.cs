using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите своё имя");

        var name = Console.ReadLine();
        var eman = "";

        Console.WriteLine("Ваше имя по буквам: ");

        foreach (var ch in name)
        {
            eman = ch + eman;
        }

        Console.WriteLine(eman);

        Console.ReadKey();
    }
}
