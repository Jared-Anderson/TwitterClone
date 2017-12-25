using TwitterClone.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace TwitterClone.DAL
{
    public class PostContext : DbContext
    {

        public PostContext() : base("PostContext")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserPost> UserPosts { get; set; }
       
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}