using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2
{
    internal static class ItemManager
    {
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

        public override string ToString()
        {
            string collect = this.type + "av märket: " + this.make + "\n" +
                this.Condition + "\n---------------------------";

            return collect;
        }
    }


}
