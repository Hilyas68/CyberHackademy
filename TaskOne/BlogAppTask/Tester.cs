using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskOne.BlogAppTask.EFRepository;
using TaskOne.BlogAppTask.Model;

namespace TaskOne.BlogAppTask
{
    class Tester
    {
        public static void Main()
        {
            Add_edit();
            FindBy();
            //Find By
            

            //Console.Read();
        }

        public static void Delete()
        {
            var post = new EFRepository<BlogDBContext, Post>();
            var result = post.Delete(3);
        }

        public static void GetAll()
        {
            var post = new EFRepository<BlogDBContext, Post>();
            var result = post.GetAll();
            foreach (var item in result)
            {
                Console.WriteLine(item.Title + " " + item.Body);
            }

        }

        public static void GetSingle()
        {
            var post = new EFRepository<BlogDBContext, Post>();
            var result = post.GetSingle(2);
          
                Console.WriteLine(result.Title + " " + result.Body);
            
        }
        public static void FindBy()
        {
            var post = new EFRepository<BlogDBContext, Post>();
            var result = post.FindBy(a => a.Title.Equals("EntityFramework")).ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item.Title + " " + item.Body);
            }
        }
        public static  void Add_edit()
        {
            var c = new Post()
            {
                CreatedDate = DateTime.Now,
                Title = "Csharp",
                Body = "Csharp in a nutshell"
            };

            var post = new EFRepository<BlogDBContext, Post>();

            post.Add(c);
            c.Title = "EntityFramework";
            post.Edit(c);

        }
    }
}
