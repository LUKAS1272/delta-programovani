namespace Booleans;

class Program
{
    static void Main(string[] args)
    {
        // V C# a jiných programovacích jazycích existuje i další datový typ - boolean
        // Pro definici proměnné používáme bool
        // Boolean může mít pouze 2 hodnoty

        // true - pravda
        bool isDay = true;

        // false - nepravda
        bool isNight = false;

        // Stejně jako s ostatními datovými typy, i boolean můžeme vypsat do konzole
        Console.WriteLine("Je den? : " + isDay);
        Console.WriteLine("Je noc? : " + inNight);

        // Boolean můžeme zároveň nastavit, jako výsledek nějakého porovnání
        // V matice můžeme porovnávat pomocí:
        // - Je větší (>)
        // - Je menší (<)
        // - Je rovno (=)
        // - Není rovno (≠)
        // - Je větší nebo rovno (≥)
        // - Je menší nebo rovno (≤)

        // V programování pro rovnost nepoužíváme pouze jedno rovnítko (=), ale 2 (==)
        // Je tomu tak kvůli tomu, že pomocí jednoho rovnítka říkáme počítači, aby nějakou hodnotu nastavil
        Console.WriteLine(8 == 5) // 8 je rovno 5 - nepravda
    }
}