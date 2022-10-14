using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2
{
    internal static class Flood
    {
        /// <summary>
        /// Debugging method, floods a list of kitchen appliances to test functions in the software.
        /// </summary>
        /// <param name="list">The list to be flooded.</param>
        static public void List(ref List<KitchenApp> list)
        {
            list.Add(new KitchenApp("Våffeljärn", "Electrolux", true));
            list.Add(new KitchenApp("Spishäll", "Heat Master", false));
            list.Add(new KitchenApp("Vattenkokare", "King of Tea", true));
            list.Add(new KitchenApp("Ugn", "Electrolux", true));
            list.Add(new KitchenApp("Brödrost", "PowerBready", false));
            list.Add(new KitchenApp("Microvågsugn", "Bosch", true));
            list.Add(new KitchenApp("Degknådare", "Kitchen Master", true));
            list.Add(new KitchenApp("Diskmaskin", "Bosch", false));
            list.Add(new KitchenApp("Fritös", "Electrolux", true));
            list.Add(new KitchenApp("Blender", "Magic Bullet", true));
            list.Add(new KitchenApp("Ångkokare", "Kitchen Master", true));
            list.Add(new KitchenApp("Köksfläkt", "Electrolux", true));
            // Flood list of kitchen applications here.
            // This method is for debugging.
        }
    }
}
