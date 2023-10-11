namespace AddingStrings;

class Program
{
    static void Main(string[] args)
    {
        string pozdrav = "Hello";

        // Console.WriteLine() hodnotu v proměnné 'pozdrav' vypíše
        Console.WriteLine(pozdrav);

        // Hodnoty proměnných nemusíme jen přepisovat, ale můžeme je i "sčítat"
        // Kód níže upraví hodnotu proměnné 'pozdrav'
        // Nejdříve přečte hodnotu proměnné 'pozdrav' ("Hello") a hned za ní přidá text (" World!")
        // Tímto spojením docílíme textu "Hello World!"
        pozdrav = pozdrav + " World!";

        // Console.WriteLine() hodnotu v proměnné 'pozdrav' opět vypíše - tentokrát už ale hodnotu změněnou
        Console.WriteLine(pozdrav);
    }
}
