namespace Else;

class Program
{
    static void Main(string[] args)
    {
        // Někdy se stává, že ani jedná z podmínek v sekvenci není true
        // Kvůli tomu by se nic nestalo - jen by se všechny codeblocky přeskočily, protože ani jedna z podmínek není pravdivá
        // Co když ale i přesto chceme něco udělat?
        // Třeba vypsat, že ani jedna z předchozích podmínek nebyla pravdivá

        // Pokud chceme něco takového udělat, musíme použít else
        // Else je koncová část podmínky
        // Jedná se o 'poslední bod záchrany', který se spustí v případě, že ani jedna z předchozích podmínek nebyla true

        // Narozdíl od if nebo else if nepotřebujeme podmínku
        // Ani by to nedávalo smysl - kód v else chceme spustit ať se děje, co se děje

        // Else vždy následuje alespoň po jedné podmínce
        // Může to být podmínka jediná
        if (0 > 10)
        {
            Console.WriteLine("0 je větší, než 10");
        }
        else
        {
            Console.WriteLine("0 NENÍ větší, než 10");
        }

        // Mohou být 3
        if (0 > 10)
        {
            Console.WriteLine("0 je větší, než 10");
        }
        else if (6 == 8)
        {
            Console.WriteLine("6 je rovno 8");
        }
        else if (100 < 4)
        {
            Console.WriteLine("100 je menší, než 4");
        }
        else // Nepíšeme žádnou podmínku, jako u ifu, nebo else ifu
        {
            Console.WriteLine("Ani jedna z podmínek výše není pravdivá...");
        }

        // Může jich být třeba i 100
        // Jediná podmínka je, že else musí být v řadě podmínek vždy poslední
        


        // Pravidla pro podmínky
        // - první je vždy if, používáme ho pouze jednou
        // - po něm mohou (ale také nemusí) následovat else if
        // - else if fungují tak, že pokud se nespustí kód v if, přečte se podmínka else if a pokud je pravdivá, pustí se kód v else if
        // - poslední je (pokud ho chceme použít > používat ho nemusíme) else, ten je poslední záchranou
        // - pokud není ani jedna z podmínek pravdivá, else se spustí nezávisle na jakékoli podmínce
        // - else je vždy v sekvenci poslední a stejně jako if je JEDINÝ
    }
}