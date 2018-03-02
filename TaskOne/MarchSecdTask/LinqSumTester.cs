using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne.MarchSecdTask
{
    class LinqSumTester
    {
        public static void Main()
        {
            var inventories = InventoryManager.GetInventories();
           
            foreach (var item in inventories)
            {
                Console.WriteLine($"{item.Name} : {item.Price}");
            }

            var sumOfPrice = inventories.Sum(s => s.Price);

            Console.WriteLine($"Total price = N{sumOfPrice}");

        }
    }
}
