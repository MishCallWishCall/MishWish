using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MissWish.Models
{

    public partial class MissWishEntities : DbContext
    {
        public MissWishEntities()
            : base("name=MissWishEntities")
        {
        }

        public DbSet<User> User { get; set; }

        public DbSet<Contact> Contact { get; set; }

        public DbSet<AccountType> AccountType { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
