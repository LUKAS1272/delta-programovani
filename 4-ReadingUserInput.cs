namespace ReadingUserInput;

class Program
{
    static void Main(string[] args)
    {
        // V našich programech chceme někdy načíst i vstup od uživatele
        // Je dobré nejdříve uživatele vyzvat k nějaké akci, aby věděl, jak má náš program používat
        Console.Write("Zadej své jméno: ");

        // Uživatelský vstup většinou ukládáme do proměnných a protože se jedná text, jako typ proměnné zvolíme 'string'
        // Protože načítáme vstup z konzole, opět použijeme class 'Console' a pro načtení method 'ReadLine()'
        // Opět si dejte pozor, abyste psali správně malá a velká písmena (i jedno špatně napsané písmeno znamená, že váš kód nebude fungovat)
        string jmeno = Console.ReadLine();

        // Pokud compiler (program, co prochází a spouští náš kód) narazí na ReadLine, čeká, dokud uživatel nepotvrdí nějaký vstup enterem
        // Jesti se vám stane, že se váš program zastaví a nic dalšího nedělá, možná jen máte nějaký nepotvrzený vstup

        // Zkombinováním znalosti čtení vstupu uživatele a spojování stringů můžeme uživatele pozdravit
        Console.WriteLine("Ahoj " + jmeno);

        // Pokud bychom tento řádek s výpisem vynechali, kód by sice načetl jméno uživatele, ale tam by skončil
        // Jestli kódu neřekneme, aby načtenou hodnotu i vypsal, neudělá to
    }
}