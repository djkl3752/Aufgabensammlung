namespace Monatsnamen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo, dies ist die Monatsanzeige:");

            Console.WriteLine("Gib eine Zahl von 1-12 ein: ");
            string Monatszahl = Console.ReadLine();

            if(Monatszahl == "1")
            {
                Console.WriteLine("Der Monat ist Januar.");
            }
            if(Monatszahl == "2")
            {
                Console.WriteLine("Der Monat ist Januar.");
            }
            if(Monatszahl == "3")
            {
                Console.WriteLine("Der Monat ist März.");
            }
            if(Monatszahl == "4")
            {
                Console.WriteLine("Der Monat ist April.");
            }
            if(Monatszahl == "5")
            {
                Console.WriteLine("Der Monat ist Mai.");
            }
            if(Monatszahl == "6")
            {
                Console.WriteLine("Der Monat ist Juni.");
            }
            if(Monatszahl == "7")
            {
                Console.WriteLine("Der Monat ist Juli.");
            }
            if(Monatszahl == "8")
            {
                Console.WriteLine("Der Monat ist August.");
            }
            if(Monatszahl == "9")
            {
                Console.WriteLine("Der Monat ist September.");
            }
            if(Monatszahl == "10")
            {
                Console.WriteLine("Der Monat ist Oktober.");
            }
            if(Monatszahl == "11")
            {
                Console.WriteLine("Der Monat ist November.");
            }
            if(Monatszahl == "12")
            {
                Console.WriteLine("Der Monat ist Dezember.");
            }
            if(Monatszahl >= 12)
            {
                Console.WriteLine("Fehler: Zahl zwischen 1 und 12 erwartet");
            }
        }
    }
}

