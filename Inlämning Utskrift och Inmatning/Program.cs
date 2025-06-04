class Program
{
    static void Main(string[] args)
    {
        // Användare får möjlighet att kriva in sitt fullständiga namn
        Console.Write("Ange ditt fullständiga namn:");

        // Läs in namnet från konsolen och spara det i en variabel. Utan deklaration av variabeltyp sparas ej inmatningen i en variabel
        string fullständigtNamn = Console.ReadLine();

        // Skriv ut ett välkomstmeddelande som inkluderar det fullständiga namnet
        Console.WriteLine("Hej och välkommen," + fullständigtNamn);

        // Fråga användaren om deras ålder
        Console.Write("Ange din ålder: ");

        // Läs in åldern från konsolen och spara den i en variabel. Utan deklaration av variabeltyp sparas ej inmatningen i en variabel
        string ålder = Console.ReadLine();

        // Konverterar inmatningen till ett heltal. Int används vid heltal vilket är de jag behöver just nu.
        int nr = Convert.ToInt32(ålder);

        // Skriv ut åldern i konsolen och antal dagar du levt. Skriver ut en sträng som innehåller åldern med variablen nr.
        Console.WriteLine("Du är " + nr + " år gammal och har levt i " + (nr *365) + " dagar");

        // Fråga användaren om de vill veta hur många dagar de har levt
        //Console.WriteLine("Vill du veta hur många dagar du levt? (Y/n): ");  UTVECKLA SEANRE VID IF-SATSER

        // Läs in användarens svar
        //string svar = Console.ReadLine();

        //Detta är ett alternativ om jag vill ha 2 olika utmaningar. Modifiera rad 24 och utkommentera rad 33.
        //Console.WriteLine("Du har levt i " + (nr * 365) + " dagar");
        Console.ReadLine();
    }
}

