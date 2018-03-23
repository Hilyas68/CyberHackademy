﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne.BlogAppTask.Model
{
   public class Post:BaseModel
    {
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Body { get; set; }
    }
}