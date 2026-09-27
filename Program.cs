namespace DiceThrow;

class Program
{
    static void Main(string[] args)
    {
        //Uppgift 4 – Tärningskastet
        // Du ska simulera ett tärningskast.
        Console.WriteLine("//// WELCOME TO DICETHROW ////");
        // Instruktioner:
        // Använd klassen Random (inbyggd i C#) för att skapa ett slumptal mellan 1 och 6.
        Random rnd = new Random();
        int number1 = rnd.Next(1,7);
        int number2 = rnd.Next(1,7);

        // Skriv ut resultatet på skärmen.
        Console.WriteLine($"Du kastade: {number1} och {number2}");
        // Extra: Låt programmet kasta två tärningar och skriv ut summan.
        int Totalt = number1 + number2;
        Console.WriteLine($"Summan av båda kasten: {Totalt}");
    }
}
