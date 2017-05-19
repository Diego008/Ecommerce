using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace E_commerce.Models
{
    public class Context : DbContext
    {
        public Context()
            : base("Ecommerce")
        {
            Configuration.ProxyCreationEnabled = false;
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>());
        }
        
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }        
        public DbSet<Admin> Admins { get; set; }
       
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }        
    }
}