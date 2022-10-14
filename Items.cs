using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Labb2
{
    internal static class ItemMngr
    {
        public static void AddItem(ref List<KitchenApp> list)
        {
            string type = "";
            string brand = "";
            bool isFunctioning;

            Console.Clear();
            Console.Write("Registrering av ny utrustning:\n\n" +
                "Ange typ: ");
            type = Console.ReadLine();
            Console.Write("Ange märke: ");
            brand = Console.ReadLine();
            Console.Write("Användbart skick? (y/n): ");
            isFunctioning = MenuManager.ParseTruefalse(Console.ReadLine());

            list.Add(new (type, brand, isFunctioning));
            Console.WriteLine("Utrustningen är registrerad!");
        }

        public static void RemoveItem(ref List<KitchenApp> list)
        {
            Console.Clear();
            Console.Write($"Det finns {list.Count} antal utrustningar registrerade.\n" +
                $"Välj index för borttagning: ");

            int selection;
            bool validOpt = Int32.TryParse(Console.ReadLine(), out selection);
            while (!validOpt || selection <= 0 || selection > list.Count)
            {
                Console.Write("Ogiltigt val! Försök igen: ");
                validOpt = Int32.TryParse(Console.ReadLine(), out selection);
            }

            Console.WriteLine(list[selection - 1].ToString);
            Console.Write("Ta bort den valda utrustningen? (j/n): ");

            bool accept = MenuManager.ParseTruefalse(Console.ReadLine());
            if (!accept) MenuManager.AwaitConfirm(); return;

            list.RemoveAt(selection - 1);
            MenuManager.AwaitConfirm();
            
        }

        public static void ListItems(List<KitchenApp> list)
        {
            Console.Clear();
            
            if (list.Count == 0)
            {
                Console.WriteLine("Det finns ingen köksutrustning registrerad!");
                MenuManager.AwaitConfirm();
                return;
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine((i + 1) + ": " + list[i].ToListString());
            }
            Console.WriteLine("========================\n" +
                "Listan skriven!");
            MenuManager.AwaitConfirm();
            return;
        }
    }
    internal abstract class Item : IKitchenAppliance
    {
        public string Type { get; set; }
        public string Brand { get; set; }
        public bool IsFunctioning { get; set; }

        public void Use()
        {
            if (!IsFunctioning)
            {
                Console.WriteLine("Utrustningen är ur funktion!\n" +
                    "Vänligen tillkalla tekniker.");
                return;
            }

            else
            {
                Console.WriteLine("Initierar utrustning.\n" +
                    "Vänta...\n\n");
                Console.WriteLine("Utrustning laddar parametrar.\n" +
                    "Parameterladdning klar! Utrustning i bruk.");
            }
        }
    }

    internal class KitchenApp : Item
    {
        public KitchenApp(string type, string brand, bool IsFunctioning)
        {
            base.Type = type;
            base.Brand = brand;
            base.IsFunctioning = IsFunctioning;
        }

        public void SetFunctioning(bool set)
        {
            base.IsFunctioning = set;
        }

        public override string ToString()
        {
            string returnValue = base.Type + " av märket " + base.Brand + ".\n";
            if (IsFunctioning) returnValue = returnValue + "Skick: Fungerande.";
            else returnValue = returnValue + "Skick: Trasig.";

            returnValue = returnValue + "\n---------------------------------\n";

            return returnValue;
        }

        public string ToListString()
        {
            string returnValue = base.Type + " - " + base.Brand;

            if (base.IsFunctioning) returnValue += " - Användbart skick";
            else returnValue += "Trasig";

            return returnValue;
        }
    }
}
