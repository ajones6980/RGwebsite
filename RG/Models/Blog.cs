using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RG.Models
{
    public class Blog
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BlogID { get; set; }
        public int CmtCount { get; set; }
        public string Title { get; set; }
        public string Topic { get; set; }
        public string Author { get; set; }

        public virtual ICollection<Subscription> Subscriptions { get; set; }
    }
}