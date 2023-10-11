namespace WritingTextToConsole;

class Program
{
    static void Main(string[] args)
    {
        // V C# můžeme vypisovat různé texty do konzole
        // Pro konzoli existuje speciální "Class" (třída), která v sobě ukrývá další "Methods" (metody, funkce)
        // Tyto methods zpřístupníme pomocí tečky
        // Pokud chceme do konzole vypsat text, musí být v uvozovkách
        Console.WriteLine("Hello World!");
        
        // POZOR: Kód o řádek níže by nefungoval, protože v C# musí být názvy tříd a metod přesně (malá a velká písmena)
        // console.writeline("Hello World!");

        // Každý příkaz se v C# ukončuje pomocí znaku středníku (;)
        // Ten se nachází v levém horním rohu klávesnice přímo pod klávesou esc (pokud používáte klávesnici s českým rozložením)

        // Další možností, jak vypsat do konzole text, je Console.Write()
        // Na první pohled působí stejně, jako Cosnoel.WriteLine(), ale je trochu odlišný

        // WriteLine za vypsaný text přidá odřádkování
        Console.WriteLine("WriteLine");
        Console.WriteLine("WriteLine");
        Console.WriteLine("WriteLine");
        // Výstup těchto tří řádků výše by tedy byl:
        // WriteLine
        // WriteLine
        // WriteLine

        // Zatímco Write, vypíše pouze text v uvozovkách, a další výpis je opět na stejný řádek
        Console.Write("Write");
        Console.Write("Write");
        Console.Write("Write");
        // Výstup těchto tří řádků výše by tedy byl:
        // WriteWriteWrite
    }
}
