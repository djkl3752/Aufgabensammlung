namespace Addierer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dieses Programm berechnet die Summe von zwei Zahlen.");

            Console.Write("Zahl 1: ");
            string eingabe1 = Console.ReadLine();
            int zahl1 = Convert.ToInt32(eingabe1);

            Console.Write("Zahl 2: ");
            string eingabe2 = Console.ReadLine();
            int zahl2 = Convert.ToInt32(eingabe2);

            int summe = zahl1 + zahl2;

            Console.WriteLine("Die Summe ist: " + summe);
        }
    }
}
