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
    }
}