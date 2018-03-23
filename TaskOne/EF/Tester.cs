using NinjaDomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskOne.EF
{
    class Tester
    {
        public static void Main()
        {

            SimpleNinjaQueries();
            Console.Read();
        }

        private static void InsertNinja()
        {
            var ninja = new Ninja()
            {
                Name = "JulieSan",
                ServedInOniwaban = true,
                DateOfBirth = new DateTime(1980, 1, 3),
                ClanId = 1
            };

            using (var context = new NinjaContext())
            {
                context.Database.Log = Console.WriteLine; 
                context.Set<Ninja>().Add(ninja);
                context.SaveChanges();
            }
        }

        private static void InsertBulkNinja()
        {
            var ninja = new Ninja()
            {
                Name = "Leonardo",
                ServedInOniwaban = true,
                DateOfBirth = new DateTime(1980, 1, 3),
                ClanId = 1
            };

            var ninja1 = new Ninja()
            {
                Name = "SampsonSan",
                ServedInOniwaban = true,
                DateOfBirth = new DateTime(1980, 1, 3),
                ClanId = 1
            };

            using (var context = new NinjaContext())
            {
                context.Database.Log = Console.WriteLine;
                context.Set<Ninja>().AddRange(new List<Ninja> {ninja, ninja1 });
                context.SaveChanges();
            }
        }

        private static void SimpleNinjaQueries()
        {
            using (var context = new NinjaContext()) {
                var ninjas = context.Set<Ninja>().Where(s=> s.Name == "Leonardo").FirstOrDefault();
                //foreach (var item in ninjas.Name)
                //{
                    Console.WriteLine(ninjas.Name);
               // }
            }
        }
    }
}
