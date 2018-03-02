using System;
using System.Linq;

namespace TaskOne.MarchSecdTask
{
    class UsingOtherOperations
    {
        public static void Main()
        {
            var getInventories = InventoryManager.GetInventories();

            var freshInventories = InventoryManager.FreshInventories();


            Console.WriteLine("....................CONCAT...............................");

            var concat = getInventories.Concat(freshInventories);

            foreach (var item in concat)
            {
                Console.WriteLine($"{item.Id} {item.Name} : \t {item.Price} \t {item.EntryDate.ToString("MM:dd:yyyy hh:mm:ss")}");
            }

            Console.WriteLine();
            Console.WriteLine("....................Union...............................");

            var union = getInventories.Union(freshInventories, new InventoryComparer());

            foreach (var item in union)
            {
                Console.WriteLine($"{item.Id} {item.Name} : \t {item.Price} \t {item.EntryDate.ToString("MM:dd:yyyy hh:mm:ss")}");
            }

            Console.WriteLine();
            Console.WriteLine("....................DISTINCT...............................");

            var distinct = getInventories.Distinct();

            foreach (var item in distinct)
            {
                Console.WriteLine($"{item.Id} {item.Name} : \t {item.Price} \t {item.EntryDate.ToString("MM:dd:yyyy hh:mm:ss")}");
            }

            Console.WriteLine();
            Console.WriteLine("....................INTERSECT...............................");

            var intersect = getInventories.Intersect(freshInventories ,new InventoryComparer());

            foreach (var item in intersect)
            {
                Console.WriteLine($"{item.Id} {item.Name} : \t {item.Price} \t {item.EntryDate.ToString("MM:dd:yyyy hh:mm:ss")}");
            }

            Console.WriteLine();
            Console.WriteLine("....................EXCEPT...............................");

            var except = getInventories.Except(freshInventories, new InventoryComparer());

            foreach (var item in except)
            {
                Console.WriteLine($"{item.Id} {item.Name} : \t {item.Price} \t {item.EntryDate.ToString("MM:dd:yyyy hh:mm:ss")}");
            }

        }
    }
}
 