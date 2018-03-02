using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne.MarchSecdTask
{
    class SkipWhileTester
    {
        public static void Main()
        {

            var inventories = InventoryManager.GetInventories();

            foreach (var item in inventories)
            {
                Console.WriteLine($"{item.Name} : {item.Price}");
            }

            Console.WriteLine("....................Skip While...............................");
            var skipWhilePrice = inventories.SkipWhile((s) => s.Price > 400);

            foreach (var item in skipWhilePrice)
            {
                Console.WriteLine(item.Price);
            }

            Console.WriteLine("....................Take While...............................");

            var takeWhile = inventories.TakeWhile((s) => s.Price > 400);
            foreach (var item in takeWhile)
            {
                Console.WriteLine(item.Price);
            }
        }
    }
}
