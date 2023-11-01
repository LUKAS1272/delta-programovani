namespace Doubles;

class Program
{
    static void Main(string[] args)
    {
        // Pokud potřebujeme v kódu použít číslo, které má desetinné místo (například 7.5) nemůžeme použít int proměnnou
        // Int je zkratka pro integer - což v angličtině znamená celé číslo
        // Do intových proměnných můžeme tedy ukládat pouze celá čísla

        // Pokud chceme vytvořit proměnnou obsahující číslo s desetinným místem, musíme použít jiný typ proměnné
        // Tímto typem proměnné je double


        // Do proměnné 'decimalNumber' ukládáme číslo 7.5
        // Kdybychom se pokusili uložit stejné číslo do intové proměnné, dostali bychom error
        double decimalNumber = 7.5;


        // Double proměnné jsou užitečné i v případě dělení čísel
        // Při dělení se nám stávají situace, kdy je výsledkem desetinné číslo
        
        int firstNumber = 5;
        int secondNumber = 2;
        // Dělíme číslo 5 číslem 2 - očekávaný výsledek je 2.5
        Console.WriteLine(firstNumber / secondNumber); // Skutečný výsledek je ale 2
        // Problém je to, že dělíme dvě celá čísla
        
        
        // Když dělíme dvě celá čísla (inty) a výsledkem je desetinné číslo, C# "usekne" číslo za desetinnou čárkou a ponechá pouze to, co bylo před ní
        // - 2.5 > 2
        // - 0.9 > 0
        // - 6.66 > 6
        

        // Pokud chceme, aby byl výsledek desetinné číslo, musí být ALESPOŇ JEDNA proměnná ve tvaru double
        double thirdNumber = 5;
        int fourthNumber = 2;
        Console.WriteLine(thirdNumber / fourthNumber); // Výsledek je 2.5, protože dělenec (thirdNumber) má datový typ double

        int fifthNumber = 5;
        double sixthNumber = 2;
        Console.WriteLine(fifthNumber / sixthNumber); // Výsledek je 2.5, protože dělitel (sixthNumber) má datový typ double

        double seventhNumber = 5;
        double eighthNumber = 2;
        Console.WriteLine(seventhNumber / eighthNumber); // Výsledek je 2.5, protože dělenec (seventhNumber) i dělitel (eighthNumber) mají datový typ double


        // Pokud se pokusíme uložit výsledek po matematické operaci s double proměnnými do intové proměnné, dostaneme error
        double firstSumDouble = 2;
        double secondSumDouble = 5;
        // int doublesSum = firstSumDouble + secondSumDouble;
        // Řádek výše by způsobil error, protože se snažíme uložit číslo s datovým typem double do proměnné s datovým typem int
        // Místo toho bychom museli uložit výsledek operace do double proměnné
        double doublesSum = firstSumDouble + secondSumDouble;
        Console.WriteLine(doublesSum);
    }
}
