using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskOne.RandomTask;

namespace TaskOne.MarchSecdTask
{
    class InventoryManager
    {
        public static IEnumerable<Inventory> FreshInventories()
        {
            ArrayList dd;
            Hashtable s = new Hashtable();
            s.Remove("");
            s.Add("ss", "www");
            List<Inventory> inventories = new List<Inventory>()
            {
                new Inventory()
                {
                    Id = 5,
                    Name = "IPhone X",
                    Price = 50000,
                    Categories = new List<Category>{ GetCategories()[1] , GetCategories()[2] }
                },

                new Inventory()
                {
                    Id = 3,
                    Name = "Samsung S8",
                    Price = 700000,
                    Categories = new List<Category>{ GetCategories()[1] , GetCategories()[2] }               
                },

                 new Inventory()
                {
                    Name = "Surface Book 2",
                    Price = 800000,
                    EntryDate = DateTime.Now,
                    Categories = new List<Category>{ GetCategories()[1] , GetCategories()[2] }                   
                }
            };

            return inventories;

        }
        public static IEnumerable<Inventory> GetInventories()
        {
            List<Inventory> inventories = new List<Inventory>()
            {

                new Inventory()
                {
                    Id = 5,
                    Name = "Lenovo X1 Carbon",
                    Price = 300000,
                    EntryDate = new DateTime(11/02/2016),
                    Categories = new List<Category>{ GetCategories()[1] , GetCategories()[2] }
                },

                new Inventory()
                {
                    Id = 2,
                    Name = "Keyboard",
                    Price = 500,
                    EntryDate = new DateTime(12/03/17),
                    Categories = new List<Category>{ GetCategories()[0] }
                },

                 new Inventory()
                {
                    Id = 3,
                    Name = "Mouse",
                    Price = 350,
                    EntryDate = new DateTime(30/03/17),
                    Categories = new List<Category>{ GetCategories()[2], GetCategories()[3] }
                },

                 new Inventory()
                {
                    Id = 4,
                    Name = "VGA Converter",
                     Price = 750,
                      EntryDate = new DateTime(30/03/17),
                    Categories = new List<Category>{ GetCategories()[0], GetCategories()[3] }
                },

                 new Inventory()
                {
                    Id = 1,
                    Name = "Hard Disk",
                     Price = 15000,
                      EntryDate = new DateTime(30/03/17),
                    Categories = new List<Category>{ GetCategories()[0] , GetCategories()[1] }
                }


            };

            return inventories;

        }

        public static List<Category> GetCategories()
        {
            Category[] categories = new Category[4]
            {
                new Category(){ Name = "Computer Accessorires"},
                 new Category(){ Name = "Laptop"},
                    new Category(){ Name = "Computer Gadget"},
                    new Category(){ Name = "Computer Gadget"}
            };

            return categories.ToList();
        }
    }
}
