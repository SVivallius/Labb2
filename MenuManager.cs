
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2
{
    internal static class MenuManager
    {
        static public void AwaitConfirm()
        {
            Console.WriteLine("Tryck på valfri tangent för att återgå.");
            Console.ReadKey();
        }

        public static int MenuSelection(int menuLength)
        {
            start:
            Int32.TryParse(Console.ReadLine(), out int selection);
            if (selection == 0 && selection > menuLength)
            {
                Console.Write("Ogiltigt val! Försök igen: ");
                goto start;
            }
            return selection;
        }

        public static bool ParseTruefalse(string input)
        {
            bool resolved = false;
            bool result = false;

            while (!resolved)
            {
                switch (input.ToLower())
                {
                    case "ja": result = true; resolved = true; break;
                    case "j": result = true; resolved = true; break;
                    case "nej": result = false; resolved = true; break;
                    case "n": result = false; resolved = true; break;

                    default:
                        Console.Write("Ogiltigt svar! Försök igen: ");
                        input = Console.ReadLine();
                        resolved = false;
                        break;
                }
            }
            return result;
        }

        static public void BuildMenu()
        {
            Console.Clear();
            Console.Write("Styrprogram för köksutrustning.\n\n" +
                "Välj:\n" +
                "1) Använd\n" +
                "2) Lägg till ny\n" +
                "3) Lista\n" +
                "4) Ta bort\n" +
                "5) Avsluta\n\n" +
                "Ditt val: ");
        }

        static public void BuildSubMenu(List<KitchenApp> list)
        {
            Console.Clear();
            Console.WriteLine("Aktivering av utrustning.\n" +
                "Det finns {0} utrustningar registerade", list.Count);
            Console.Write("\nVälj utrustning: ");
            int selection = MenuManager.ForceValidSelect();

            while (selection <= 0 || selection >= list.Count)
            {
                Console.Write("Ogiltigt val! Försök igen: ");
                selection = MenuManager.ForceValidSelect();
            }


        }

        static private int ForceValidSelect()
        {
            int output = 0;
            bool resolved = false;
            while (!resolved)
            {
                string input = Console.ReadLine();
                resolved = Int32.TryParse(input, out output);

                if (!resolved) Console.Write("Ogiltigt svar! Försök igen: ");
            }

            return output;
        }
    }
}
