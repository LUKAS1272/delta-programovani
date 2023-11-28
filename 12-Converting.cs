namespace Converting;

class Program
{
    static void Main(string[] args)
    {
        // Jak bychom vytvořili program, který se zeptá uživatele na číslo
        // Následně vypíše, jestli je toto číslo kladné, záporné, nebo neutrální - 0

        // Abychom tento program vytvořili, musíme si načíst číslo a poté pomocí podmínek určit, o jaké číslo se jedná
        // Číslo od uživatele načteme pomocí Console.ReadLine
        // Tento vstup si uložíme do proměnné
        
        // O jaké číslo se jedná určíme tím, že číslo, které nám uživatel zadal porováme s nulou
        // Pokud je číslo menší, než 0 - je záporné
        // Pokud je číslo větší, než 0 - je kladné
        // Pokud je číslo rovno 0 - je neutrální (0)


        // Pokud ale chceme porovnat nějakou proměnnou s číslem, její datový typ ("tvar krabice") musí být stejný
        // Datový typ proměnné tedy musí být také číslo - int

        // Kód níže nebude fungovat, protože porovnáváme číslo s textem
        // if (0 < "10")
        // {
        //     Console.WriteLine("0 je menší, než 10");
        // }


        // Pokud se ale pokusíme uložit vstup od uživatele, jako to děláme na řádku níže, dostaneme error
        // int cislo = Console.ReadLine();
        
        // Jak je to možné?
        // Console.ReadLine vrací v základu text - string
        // My se ale tento text snažíme uložit do číselné proměnné - int
        // Snažíme se uložit text do čísla - to prostě nejde


        // Jak to tedy uděláme?
        // Musíme si text, který nám uživatel zadá převést na číslo, abychom ho mohli uložit do intové proměnné
        // Text můžeme převést na text pomocí takzvaného "convert"

        // Convert začínáme slovem Convert, kterým programu řekneme, že chceme něco převést (convert v angličitně znamená převést)
        // Následuje tečka a typ, na který chceme hodnotu převést
        // Pro nás tímto typem bude int, protože chceme převést náš text na číslo

        // Pro převedení na číslo použijeme "ToInt32"
        int number = Convert.ToInt32("15");
        Console.WriteLine(number);


        // S použitím této mechaniky bychom mohli dokončit i náš příklad s rozpoznáním typu čísla
        // Uživateli řekneme, aby zadal číslo
        Console.Write("Enter a number: ");
        // Do stringové proměnné si uložíme text, který nám uživatel zadá
        string userInput = Console.ReadLine();
        // Ten poté pomocí convertu převedeme na číslo
        // Text převádíme na celé číslo - int, převádíme vstup, který nám uživatel předal - userInput
        int convertedNumber = Convert.ToInt32(userInput);

        // Pomocí porovnání s nulou zjistíme, jestli je číslo kladné, záporné, nebo neutrální
        // Abyste tuto část lépe chápali, podívejte se na soubory 9-ConditionsBasics.cs & 10-Elseif.cs
        if (parserdNumber > 0) // Pokud je číslo větší, než 0 - kladné
        {
            Console.WriteLine("Číslo je kladné");
        }
        else if (convertedNumber < 0) // Pokud je číslo menší, než 0 - záporné
        {
            Console.WriteLine("Číslo je záporné");
        }
        else if (convertedNumber == 0) // Pokud je číslo rovno 0 - neutrální
        {
            Console.WriteLine("Číslo je neutrální - 0");
        }
    }
}