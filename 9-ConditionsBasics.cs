namespace ConditionsBasics;

class Program
{
    static void Main(string[] args)
    {
        // Podmínky jsou důležitou součástí programování
        // Pomocí nich můžeme programu říct, aby spustil nějaký kód pouze v případě, že to tak chceme
        
        // Příklady ze života
        // - pokud je pracovní den, jdi do školy
        // - pokud je noc, jdi spát

        // Pro pochopení podmínek je potřeba, abyste nejdřív pochopili, jak funguje boolean a porovnávání
        // Materiály najdete v souborech - 7-Booleans.cs a 8-Comparing.cs

        
        // Podmínku začínáme slovem "if" (anglické slovo pro "pokud")
        // Následuje podmínka v kulatých závorkách - ta je obvykle ve formě porovnání
        // Poslední částí podmínky je "codeblock" - kód, který se vykoná, pokud je výsledkem podmínky 'true'
        // Codeblock se ohraničuje složenými závorkami - { a }

        // Klíčové slovo if a podmínka v kulatých závorkách ve formátu porovnání
        if (5 > 2)
        {
            // Codeblock, který se spustí v případě, že výsledkem podmínky je true
            // To se v tomto případě stane, protože 5 je větší než 2
            Console.WriteLine("5 je větší, než 2");
        }

        if (5 < 2)
        {
            // Codeblock, který se spustí v případě, že výsledkem podmínky je true
            // To se v tomto případě nestane, protože 5 není menší než 2
            // Codeblock se přeskočí a program pokračuje dále
            Console.WriteLine("5 je menší, než 2");
        }


        // Dávejte si pozor na to, aby byl kód opravdu v závorkách
        // Kód níže vypíše "5 je větší než 2" i přesto, že podmínka je false
        // Je to kvůli tomu, že Console.WriteLine se nachází až za uzavírací závorkou '}'
        // Pokud chcete, aby váš kód fungoval správně, příkazy codeblocku musí být za '{' a zároveň před '}'
        
        // Příklad této CHYBY
        // if (5 < 2)
        // {
        // } Console.WriteLine("5 je větší, než 2");


        // Na konci podmínky se také nepíše středník, jako jsme to doteď dělali u každého řádku
        // Středníky jsou ukončením nějakého příkazu
        // Dalo by se říct, že funkci ukončení přikazu v podmínkách zastávají složené závorky '{' a '}'

        // Příklad této CHYBY
        // if (5 > 2);
        // {
        //     Console.WriteLine("5 je větší, než 2");
        // }
    }
}
