namespace FabriksHanteringsak
{
    internal class Program
    {

        static List<string> inventory = new List<string>();

        static void Main(string[] args)

        {

            Console.WriteLine("Välkommen till Fabrikshanteringssystemet!");



            while (true)

            {

                Console.WriteLine("\nVälj en åtgärd:");

                Console.WriteLine("1. Lägg till produkt");

                Console.WriteLine("2. Visa inventarie");

                Console.WriteLine("3. Avsluta");



                string val = Console.ReadLine();

                switch (val)

                {

                    case "1":

                        LäggTillProdukt();

                        break;

                    case "2":

                        VisaInventarie();

                        break;

                    case "3":

                        return;

                    default:

                        Console.WriteLine("Ogiltigt val. Försök igen.");

                        break;

                }

            }

        }
        static void LäggTillProdukt()

        {
            // TODO: Implementera metod för att lägga till produkt 
            Console.Write("Ange produktnamn: ");
            inventory.Add(Console.ReadLine());
            Console.WriteLine("Produkten har lagts till i inventariet.");
        }
        static void VisaInventarie()

        {

            // TODO: Implementera metod för att visa inventarie 

        }

        static void TaBortProdukt(String produktToRemove)
        {
            produktToRemove = produktToRemove.ToLower();
            inventory.Remove(produktToRemove);
            Console.WriteLine("Removed: " + produktToRemove);
        }
    }
}

