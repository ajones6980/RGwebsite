using System;
using System.Collections.Generic;

namespace RG.Models
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string AuthorName { get; set; }
      
        public virtual ICollection<Blog> Blogs { get; set; }
    }
}