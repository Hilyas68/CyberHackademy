namespace TaskOne.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TaskOne.BlogAppTask;
    using TaskOne.BlogAppTask.Model;

    internal sealed class Configuration : DbMigrationsConfiguration<TaskOne.BlogAppTask.BlogDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TaskOne.BlogAppTask.BlogDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            //context = new BlogDBContext();
            var MyfirstPost = new Post()
            {
                Title = "This is a title",
                CreatedDate = new DateTime(2018, 01, 12),
                Body = "This is the body of the first post"
            };
            var MySecondPost = new Post()
            {
                Title = "This is a second title",
                CreatedDate = new DateTime(2018, 01, 14),
                Body = "This is the body of the second post"
            };

            var MyThirdPost = new Post()
            {
                Title = "This is a third title",
                CreatedDate = new DateTime(2018, 01, 15),
                Body = "This is the body of the third post"
            };

            var MyForthPost = new Post()
            {
                Title = "This is a Forth title",
                CreatedDate = new DateTime(2018, 02, 02),
                Body = "This is the body of the Forth post"
            };

            var MyFifthPost = new Post()
            {
                Title = "This is a fifth title",
                CreatedDate = new DateTime(2018, 02, 08),
                Body = "This is the body of the fifth post"
            };

            var FirstAuthor = new Author()
            {
                FullName = "Mabi Chukwuma",
                Posts = new List<Post>()
                {
                    MyfirstPost, MySecondPost, MyThirdPost,
                }
            };

            var SecondAuthor = new Author()
            {
                FullName = "Oriahi Emmanuel",
                Posts = new List<Post>()
                {
                    MyForthPost, MyFifthPost
                }
            };

            var FirstBlog = new Blog()
            {
                Name = "Muna's Blog",
                Posts = new List<Post>()
                {
                    MyfirstPost, MySecondPost, MyThirdPost,
                }
            };

            var SecondBlog = new Blog()
            {
                Name = "Oriahi's Blog",
                Posts = new List<Post>()
                {
                    MyForthPost, MyFifthPost
                }
            };

            context.Set<Blog>().AddRange(new List<Blog>{FirstBlog, SecondBlog });
            context.Set<Author>().AddRange(new List<Author> { FirstAuthor, SecondAuthor });
            //context.Set<Author>().AddOrUpdate(a => a.FullName, SecondAuthor);
        }
    }
    
}
