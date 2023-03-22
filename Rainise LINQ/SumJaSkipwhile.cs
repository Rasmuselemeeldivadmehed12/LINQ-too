using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Andmed, mille peal LINQ päringuid teha
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // SkipWhile - jätab vahele elemendid, mis rahuldavad tingimust
        var skipwhile = numbers.SkipWhile(x => x < 5);

        Console.WriteLine("SkipWhile:");

        // Prindib välja elemendid, mis jäid alles
        foreach (var number in skipwhile)
        {
            Console.WriteLine(number);
        }

        // Sum - leiab arvude summa
        int summa = numbers.Sum();

        Console.WriteLine("\nSum:");

        // Prindib välja arvude summa
        Console.WriteLine(summa);
    }
}
