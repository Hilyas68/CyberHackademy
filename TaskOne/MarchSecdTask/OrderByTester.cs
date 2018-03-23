using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne.MarchSecdTask
{
    class OrderByTester
    {
        public static void Main()
        {
            var inventories = InventoryManager.GetInventories();

            foreach (var item in inventories)
            {
                Console.WriteLine($"{item.Id} {item.Name} : \t {item.Price} \t {item.EntryDate}");
            }


            Console.WriteLine("....................OrderBy...............................");
            var orderBy = inventories.OrderBy((s) => s.Id).ThenBy(s => s.EntryDate);

            foreach (var item in orderBy)
            {
                Console.WriteLine($"{item.Id} {item.Name} : \t {item.Price} \t {item.EntryDate}");
            }

            Console.WriteLine("....................OrderByDescending...............................");
            var orderByDescending = inventories.OrderByDescending((s) => s.Id).ThenByDescending(s => s.EntryDate);

            foreach (var item in orderByDescending)
            {
                Console.WriteLine($"{item.Id} {item.Name} : \t {item.Price} \t {item.EntryDate}");
            }

            //Testing
            var anonymousObject = new {Name = "Lara", MaritalStatus = "Married" };
            Console.WriteLine(anonymousObject.Name); 
        }
    }
}
