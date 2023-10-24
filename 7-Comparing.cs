namespace Comparing;

class Program
{
    static void Main(string[] args)
    {
        // V počítačích, stejně jako v matematice můžeme hodnoty porovnávat
        // Matematika pro porovávání používá následující znaménka
        // - Je větší (>)
        // - Je menší (<)
        // - Je rovno (=)
        // - Není rovno (≠)
        // - Je větší nebo rovno (≥)
        // - Je menší nebo rovno (≤)


        // Výsledkem porovnávání může být pouze ano (pravda - true), nebo ne (nepravda - false)
        // V programování pro tyto hodnoty používáme datový typ boolean
        // Boolean proměnnou definujeme pomocí 'bool'
        bool jeVenkuHezky = false;


        // C# pro porovnávání používá následující znaménka

        // - Je větší (>)
        Console.WriteLine(8 > 5); // Je 8 větší než 5? - Ano (true)
        Console.WriteLine(3 > 12); // Je 3 větší než 12? - Ne (false)
        Console.WriteLine(1 > 1); // Je 1 větší než 1? - Ne (false)

        // Je menší (<)
        Console.WriteLine(8 < 5); // Je 8 menší než 5? - Ne (false)
        Console.WriteLine(3 < 12); // Je 3 menší než 12? - Ano (true)
        Console.WriteLine(1 < 1); // Je 1 menší než 1? - Ne (false)

        // Je rovno (==)
        Console.WriteLine(8 == 5); // Je 8 rovno 5? - Ne (false)
        Console.WriteLine(3 == 12); // Je 3 rovno 12? - Ne (false)
        Console.WriteLine(1 == 1); // Je 1 rovno 1? - Ano (true)

        // Není rovno (!=)
        Console.WriteLine(8 != 5); // Je 8 nerovno 5? - Ano (true)
        Console.WriteLine(3 != 12); // Je 3 nerovno 12? - Ano (true)
        Console.WriteLine(1 != 1); // Je 1 nerovno 1? - Ne (false)

        // Je větší nebo rovno (>=)
        Console.WriteLine(8 >= 5); // Je 8 větší nebo rovno než 5? - Ano (true)
        Console.WriteLine(3 >= 12); // Je 3 větší nebo rovno než 12? - Ne (false)
        Console.WriteLine(1 >= 1); // Je 1 větší nebo rovno než 1? - Ano (true)

        // Je menší nebo rovno (<=)
        Console.WriteLine(8 <= 5); // Je 8 menší nebo rovno než 5? - Ne (false)
        Console.WriteLine(3 <= 12); // Je 3 menší nebo rovno než 12? - Ano (true)
        Console.WriteLine(1 <= 1); // Je 1 menší nebo rovno než 1? - Ano (true)


        // Výsledky porovnání můžeme ukládat i do proměnných
        // Tyto proměnné však musí mít datový typ 'bool'
        bool compare = 8 > 5; // Uloží do proměnné compare hodnotu true
        Console.WriteLine(compare); // Vypíše true


        // POZOR: >= a => není to stejné, pro porovnávání se používá pouze >=!
        // POZOR: <= a =< není to stejné, pro porovnávání se používá pouze <=!
        // POZOR: == a = není to stejné, pro porovnávání se používá pouze ==!
    }
}