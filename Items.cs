using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            return base.Type + " --- " + base.Brand;
        }
    }
}
