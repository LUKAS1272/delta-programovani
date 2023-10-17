namespace Variables;

class Program
{
    static void Main(string[] args)
    {
        // Proměnná je místo, kam si uložíme pod určitým jménem nějakou hodnotu
        // Můžeme vytvářet texty (string), nebo čísla

        // Proměnná se definuje pomocí jejího dadového typu (pro začátek budeme používat pouze string - textový řetězec)
        // Dále se definuje jméno, pomocí kterého program zpřístupní a přečte hodnotu proměnné
        // Následuje znak rovná se (=) a text v uvozovkách (pokud má proměnná datový typ stringu - textu)
        string pozdrav = "Hello";

        // Při každém použití jména proměnné se přečte její hodnota
        // V tomto případě hodnotu předáme funkci pro výpis hodnoty do konzole
        // Konzole přečte hodnotu proměnné pozdrav - "Hello" a tuto hodnotu vypíše
        Console.WriteLine(pozdrav);
        Console.WriteLine(pozdrav);

        // Hodnotu proměnné můžeme měnit > použijeme její jméno a za "=" napíšeme její novou hodnotu
        pozdrav = "Hello World!";

        // Tyto výpisy už místo "Hello" vypíší "Hello World!", protože jsme hodnotu proměnné upravili
        Console.WriteLine(pozdrav);
        Console.WriteLine(pozdrav);
    }
}