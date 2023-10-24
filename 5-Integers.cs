namespace Integers;

class Program
{
    static void Main(string[] args)
    {
        // V kódu můžeme kromě textu používat i čísla
        // Datový typ čísel je 'int' (podle andligckého integer - celé číslo)
        // Čislelné hodnoty ukládáme bez uvozovek
        int number = 5;

        // Číselné proměnné můžeme stejně jako ty textové vypisovat do konzole
        Console.WriteLine(number);

        // Do intových proměnných můžeme ukládat pouze celá čísla
        // Pokud bychom chtěli vytvořit proměnnou obsahující desetinné číslo, museli bychom použít jiný datový typ
        int x = 8;
        int y = 4;

        // S číselnými hodnotami můžeme provádět i matematické operace (sčítání, odčítání, násobení dělení)
        Console.WriteLine(x + y); // Sčítání pomocí +
        Console.WriteLine(x - y); // Odčítání pomocí -
        Console.WriteLine(x * y); // Násobení pomocí *
        Console.WriteLine(x / y); // Dělení pomocí /

        // Hodnoty upravené pomocí matematických operací můžeme ukládat i do intových proměnných
        // POZOR: Toto funguje pouze v případě, že je výsledkem celé číslo

        int addition = x + y; // Sčítání pomocí +
        int substraction = x - y; // Odečítání pomocí -
        int multiplication = x * y; // Násobení pomocí *
        int division = x / y; // Dělení pomocí /

        // Výpis 4 proměnných výše - výstup by měl být stejný
        Console.WriteLine(addition);
        Console.WriteLine(substraction);
        Console.WriteLine(multiplication);
        Console.WriteLine(division);
    }
}