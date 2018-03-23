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
            var c = new Post()
            {
                Title = "Csharp",
                Body = "Csharp in a nutshell"
            };

            var post = new EFRepository<BlogDBContext, Post>();
            
            post.Add(c);
            c.Title = "EntityFramework";
            post.Edit(c);

            //Find By
            var result = post.FindBy(a => a.Title.Equals("EntityFramework")).ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item.Title + " " + item.Body);
            }

            //Console.Read();
        }
    }
}
