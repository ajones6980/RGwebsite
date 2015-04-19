using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using RG.Models;

namespace RG.DAL
{
  public class SiteInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SiteContext>
    {
        protected override void Seed(SiteContext context)
        {
            var Users = new List<User>
            {
            new User{FName="Carson",LName="Alexander",SubDate=DateTime.Parse("2005-09-01")},
            new User{FName="Meredith",LName="Alonso",SubDate=DateTime.Parse("2002-09-01")},
            new User{FName="Arturo",LName="Anand",SubDate=DateTime.Parse("2003-09-01")},
            new User{FName="Gytis",LName="Barzdukas",SubDate=DateTime.Parse("2002-09-01")},
            new User{FName="Yan",LName="Li",SubDate=DateTime.Parse("2002-09-01")},
            new User{FName="Peggy",LName="Justice",SubDate=DateTime.Parse("2001-09-01")},
            new User{FName="Laura",LName="Norman",SubDate=DateTime.Parse("2003-09-01")},
            new User{FName="Nino",LName="Olivetto",SubDate=DateTime.Parse("2005-09-01")}
            };

            Users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();
            var Blogs = new List<Blog>
            {
            new Blog{BlogID=1,Title="Electrical"},
            new Blog{BlogID=2,Title="Mechanical"},
            new Blog{BlogID=3,Title="Environmental"},
            };  
            Blogs.ForEach(s => context.Blogs.Add(s));
            context.SaveChanges();
           
            var Subscriptions = new List<Subscription>
            {
            new Subscription{SubscriptionId=1, UserID=1,BlogID=1},
            new Subscription{SubscriptionId=2, UserID=1,BlogID=2},
            new Subscription{SubscriptionId=3, UserID=1,BlogID=2},
            new Subscription{SubscriptionId=4, UserID=2,BlogID=3},
            new Subscription{SubscriptionId=5, UserID=2,BlogID=3},
            new Subscription{SubscriptionId=6, UserID=2,BlogID=1},
            new Subscription{SubscriptionId=7, UserID=3,BlogID=1},
            new Subscription{SubscriptionId=8, UserID=4,BlogID=1},
            new Subscription{SubscriptionId=9, UserID=4,BlogID=2},
            new Subscription{SubscriptionId=10, UserID=5,BlogID=2},
            new Subscription{SubscriptionId=11, UserID=6,BlogID=3},
            new Subscription{SubscriptionId=12, UserID=7,BlogID=3},
            };
            Subscriptions.ForEach(s => context.Subscriptions.Add(s));
            context.SaveChanges();
        }
    }
}