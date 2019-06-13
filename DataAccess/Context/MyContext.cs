using DataAccess.Models;
using System.Data.Entity;

namespace DataAccess.Context
{
    public class MyContext : DbContext
    {
        public MyContext() : base("MyContext") { }
        public DbSet<Item> Item { get; set; }
        public DbSet<TypeItem> Type { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Loaning> Loaning { get; set; }
        public DbSet<Return> Return { get; set; }
        public DbSet<Handover> Handover { get; set; }
        public DbSet<Procurement> Procurement { get; set; }
        public DbSet<Parameter> Parameter { get; set; }
    }
}