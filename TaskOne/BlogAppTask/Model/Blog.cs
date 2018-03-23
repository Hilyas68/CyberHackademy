using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne.BlogAppTask.Model
{
    public class Blog: BaseModel
    {
        public string Name { get; set; }
        public List<Post> Posts { get; set; }
    }
}
