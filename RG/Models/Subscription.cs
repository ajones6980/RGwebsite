using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace RG.Models
{
    public enum Grade
    {
        Newbie, Novice, GarageHead, Engineer, Teslaite
    }

public class Subscription
    {
        
        [Key]
        public int SubscriptionId{ get; set; }
       
        public int BlogID{ get; set;}
        public int UserID { get; set; }
        public Grade? Grade { get; set; }

        public virtual Blog Blog { get; set; }
        public virtual User User { get; set; }
    }
}