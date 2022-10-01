using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2
{
    internal static class ItemManager
    {
        public static void AddAppliance(ref List<Appliance> list)
        {
            Console.Clear();
            Console.Write("Registrerar ny köksutrustning. För att avbryta, skriv \"avbryt\".\n" +
                "Ange typ av utrustning: ");
            string type = Console.ReadLine();

            if (type.ToLower() == "avbryt")
            {
                Console.WriteLine("Avbryter registrering. Tryck valfri tangent för att återgå.");
                Console.ReadKey();
                return;
            }

            Console.Write("Ange märke. Om okänd, lämna tom: ");
            string make = Console.ReadLine();
            Console.Write("Ange skick: ");
            string condition = Console.ReadLine();

            if (make.Length == 0) list.Add(new Appliance(type, condition));
            else list.Add(new Appliance(type, make, condition));
        }
    }

    class Appliance
    {
        protected string type;
        protected string? make;
        protected string Condition;

        public Appliance(string type, string make, string condition)
        {
            this.type = type;
            this.make = make;
            this.Condition = condition;
        }

        public Appliance(string type, string condition)
        {
            this.type = type;
            this.Condition = condition;
        }

        public override string ToString()
        {
            string collect = this.type;
            if (this.make != null) collect = collect + " av märket: " + this.make;
            collect = collect + "\n" +
                this.Condition + "\n---------------------------";

            return collect;
        }
    }


}
