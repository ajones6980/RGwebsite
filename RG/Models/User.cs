using System;
using System.Collections.Generic;

namespace RG.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string LName { get; set; }
        public string FName { get; set; }
        public int CmtCount { get; set; }
        public DateTime SubDate { get; set; }

        public virtual ICollection<Subscription> Subscriptions { get; set; }
    }
}