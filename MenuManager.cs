using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2
{
    internal static class MenuManager
    {
        public static void BuildMenu()
        {
            // Krav: Huvudmeny med följande val
            Console.Clear();
            Console.Write("Kontrollprogram, Köksutrustning.\n" +
                "Vänlig välj nedan.\n\n" +
                "[1] Aktivera.\n" +
                "[2] Registrera ny.\n" +
                "[3] Lista.\n" +
                "[4] Ta bort.\n" +
                "[5] Avsluta applikation.\n\n" +
                "Välj: ");
        }

        public static void BuildActivateMenu(List<Appliance> appliances)
        {
            Console.Clear();
            foreach(Appliance appliance in appliances)
            {
                Console.WriteLine(appliance.ToString());
            }
        }

        public static int Selection(int menuLength)
        {
            bool validOption = false;
            int output = 0;

            while (!validOption)
            {
                string input = Console.ReadLine();

                // Krav: Try-Catch
                try
                {
                    output = Convert.ToInt32(input);
                    if (output <= menuLength && output > 0)
                    {
                        validOption = true;
                        break;
                    }
                    else
                    {
                        validOption = false;
                        Console.Write("Ogiltigt val! Försök igen: ");
                    }
                }
                catch
                {
                    validOption = false;
                    Console.Write("Ogiltigt val! Försök igen: ");
                }
            }

            return output;
        }
    }
}
