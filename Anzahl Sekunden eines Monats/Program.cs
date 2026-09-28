namespace Anzahl_Sekunden_eines_Monats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte gebe die Anzahl Tage des Monats ein (28, 29, 30 oder 31): ");
            string input = Console.ReadLine();
            int tage = 0;


            if (int.TryParse(input, out tage) == true)
            {
                if (tage >= 28 && tage <= 31)
                {
                    int seconds = tage * 24 * 60 * 60;
                    Console.WriteLine("Der Monat hat " + seconds + " Sekunden.");
                }
                else
                {
                    Console.WriteLine("Fehler: Zahl zwischen 28 und 31 erwartet");
                }
            }
            else
            {
                Console.WriteLine("Fehler: Ganzzahl erwartet");
            }
        }
    }
}
