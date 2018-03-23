using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskOne.BlogAppTask.Model.Map;

namespace TaskOne.BlogAppTask
{
    class BlogDBContext : DbContext
    {
        public BlogDBContext(): base("BlogDbContext")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<BlogDBContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new BlogMap());
            modelBuilder.Configurations.Add(new PostMap());
            modelBuilder.Configurations.Add(new AuthorMap());
        }
    }
}
