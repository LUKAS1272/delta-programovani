namespace ElseIf;

class Program
{
    static void Main(string[] args)
    {
        // Když je výsledek podmínky false, její codeblock se přeskočí

        // Podmínka je false
        if (0 > 10)
        {
            // Tento řádek se nikdy nevypíše, protože 0 nikdy nebude větší, než 10
            Console.WriteLine("0 je větší, než 10");
        }


        // Co kdybychom ale chtěli pomocí podmínek zjistit, jestli je 0 větší, menší, nebo rovno 10?
        // Jedna podmínka by nám nestačila - museli bychom za sebe napsat 3 podmínky

        if (0 > 10)
        {
            Console.WriteLine("0 je větší, než 10");
        }
        
        if (0 < 10)
        {
            Console.WriteLine("0 je menší, než 10");
        }

        if (0 == 10)
        {
            Console.WriteLine("0 je rovno 10");
        }


        // Toto je ale neefektivní, protože už po vypsání '0 je menší než 10' víme, že '0 je rovno 10' vypisovat nebudeme
        // Program tedy zbytečně bude kontrolovat další podmínku, kterou by mohl klidně přeskočit
        // Jak mu ale řekneme, aby tuto podmínku přeskočil?


        // Abychom tohoto docílili, musíme použít 'else if' - doslovně by dalo přeložit, jako 'jinak pokud'
        // Jak už název napovídá, jedná se o podmínku, kterou program zkontroluje v případě, že první podmínka není pravdivá

        // Program zkontroluje podmínku, ale zjistí, že výsledek je false
        // Přeskočí codeblock a přejde na další podmínku
        // Struktura else if je hodně podobná struktuře if - akorát místo 'if' napíšeme před podmínku v závorkách 'else if'
        if (0 > 10)
        {
            Console.WriteLine("0 je větší, než 10");
        }
        else if (0 < 10) // Tady program zjistí, že podmínka je pravdivá a vykoná codeblock
        {
            Console.WriteLine("0 je menší než 10");
        }
        else if (0 == 10) // K této podmínce se program vůbec nedostane, protože jakmile najde podmínku, která je pravdivá, přeskočí všechny zbývající else if
        {
            Console.WriteLine("0 je rovno 10");
        }

        // S použitím else if je program rychlejší, protože se nemusí zdržovat kontrolováním zbytečných podmínek
        // Kdybychom použili u všech třech podmínek pouze if, program by musel kontrolovat 3 podmínky
        // Použítím else if se zkontrolují pouze 2 podmínky a ta třetí se přeskočí


        // Else if může následovat pouze po codeblocku (kódu co se spustí, když je podmínka true) ifu, nebo dalšího else ifu
        // Mezi codeblockem ifu a začátkem else ifu nesmí být ani jeden příkaz (Console.WriteLine, Console.Readline, definice proměnné)
        // Kdyby tam nějaký příkaz byl, kód by nefungoval
        // Prázdný řádek se nepočítá - ten tam být může, ale kvůlo přehlednosti kódu se prázdné řádky mezi ify a else ify nedávají

        // Příklad této CHYBY
        // if (0 > 10)
        // {
        //     Console.WriteLine("0 je větší, než 10");
        // }
        // Console.WriteLine("Hello, World!");
        // else if (0 < 10)
        // {
        //     Console.WriteLine("0 je menší, než 10");   
        // }


        // Else if nemůžeme v sekvenci (řadě, posloupnosti) podmínek použít jako první
        // Musí vždy následovat po if, nebo po jiném else if
        // Pokud napíšeme else if jako první, compiler bude hledat nějaký if statement, který se nachází před ním, a celý kód tím rozbijeme

        // Příklad této CHYBY
        // else if (0 < 10)
        // {
        //     Console.WriteLine("0 je menší, než 10");
        // }
        // if (0 > 10)
        // {
        //     Console.WriteLine("0 je větší, než 10");   
        // }
    }
}
