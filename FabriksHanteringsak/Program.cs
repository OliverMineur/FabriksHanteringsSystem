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

                Console.WriteLine("2. Ta bort produkt");

                Console.WriteLine("3. Visa inventarie");

                Console.WriteLine("4. Avsluta");



                string val = Console.ReadLine();

                switch (val)

                {

                    case "1":

                        LäggTillProdukt();

                        break;

                    case "2":

                        VisaInventarie(inventory);

                        break;

                    case "3":
                        TaBortProdukt();
                        return;

                        SökProdukt();

                        break;

                    case "4":
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

        static void VisaInventarie(List<string> inventory)

        {
            foreach (var item in inventory)
            {
                Console.WriteLine(item);
            }
            // TODO: Implementera metod för att visa inventarie 

        }

        static void TaBortProdukt()
        {
            Console.Clear();
            string produktToRemove = Console.ReadLine();
            if (!String.IsNullOrWhiteSpace(produktToRemove))
            {
                produktToRemove = produktToRemove.ToLower();
                inventory.Remove(produktToRemove);
                Console.WriteLine("Removed: " + produktToRemove);
            }
            else
            {
                Console.WriteLine("Invalid entry");
            }
        static void TaBortProdukt(String produktToRemove)
        {
            produktToRemove = produktToRemove.ToLower();
            inventory.Remove(produktToRemove);
            Console.WriteLine("Removed: " + produktToRemove);
        }
        static void SökProdukt()
        {
            bool searchResult = false;
            Console.WriteLine("Skriv in sökord");
            String userSearch = Console.ReadLine();

            while (String.IsNullOrEmpty(userSearch))
            {
                Console.Clear();
                Console.WriteLine("Ogiltlig inmatning\n Skriv in sökord");
                userSearch = Console.ReadLine();
            }
            if (!String.IsNullOrEmpty(userSearch))
            {
                Console.WriteLine("Resultat:");
                foreach (var product in inventory)
                {
                    if (userSearch.ToLower() == product || product.Contains(userSearch))
                    {
                        Console.WriteLine($"Produkt: {product}");
                        searchResult = true;
                    }
                }
                if (searchResult == false)
                {
                    Console.WriteLine("Din sökning gav inget resultat");
                }
                Console.ReadLine();
            }
        }
    }
}

