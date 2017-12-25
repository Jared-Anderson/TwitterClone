using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TwitterClone.Models;

namespace TwitterClone.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PostContext>
    {
        protected override void Seed(PostContext context)
        {
            var users = new List<User>
            {
            new User{FirstName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new User{FirstName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new User{FirstName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new User{FirstName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new User{FirstName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new User{FirstName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new User{FirstName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new User{FirstName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };

            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();
            var posts = new List<UserPost>
            {
            new UserPost(001, "Peggy", "Justice", "Omg this app is great I looove it <333!"),
            new UserPost(1045,"Nino", "Olivetto", "adulthood is getting drunk at your department's holiday party, getting home at midnight, then having to go to work at 8am the next day"),
            new UserPost(3141,"Yan", "Li", "I hate when someone is my class is like \"omg I need a 79 on the final to get an A in the class\" like shut up Becky I need a 135 on the final to get a C"),
            new UserPost(2021,"Gytis", "Barzdukas", "North of Lake Ladoga, Finns have made their first major counter-attack on the Red Army. 7 Finnish battalions- about 4000 men- have attacked 20,000 Soviets at Tolvajärvi, striking in a pincer movement across frozen lakes."),
            new UserPost(4041,"Laura","Norman", "Dont block me bro"),
            new UserPost(2042,"Arturo", "Anand",  "HEEEY MAN WHATS GOING ON MAAN"),
            new UserPost(4022,"Meredith", "Alonso",  "The Post is real")
            };
            posts.ForEach(s => context.UserPosts.Add(s));
            context.SaveChanges();
        }
    }
}