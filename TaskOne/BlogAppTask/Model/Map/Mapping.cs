using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne.BlogAppTask.Model.Map
{
    public class BlogMap: EntityTypeConfiguration<Blog>
    {
        public BlogMap()
        {
            this.Property(a => a.Name).HasMaxLength(150);
        }
    }

    public class PostMap : EntityTypeConfiguration<Post>
    {
        public PostMap()
        {
            this.Property(a => a.Title).HasMaxLength(150);
            this.Property(a => a.Body).HasMaxLength(500);
        }
    }

    public class AuthorMap : EntityTypeConfiguration<Author>
    {
        public AuthorMap()
        {
            this.Property(a => a.FullName).HasMaxLength(150);
        }
    }
}
