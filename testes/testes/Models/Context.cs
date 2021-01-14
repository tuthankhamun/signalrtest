using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using testes.Models;


namespace testes.Models
{
    public class Context : DbContext
    {
        public Context() : base("testes")
        {
            Configuration.ProxyCreationEnabled = false;
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>());
        }
        public DbSet<Mensagem> Mensagens { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

           // modelBuilder.Entity<Cliente>().HasMany<Transporte>(s => s.Transportes).WithMany(c => c.Clientes).Map(cs => { cs.MapLeftKey("ClienteRefId"); cs.MapRightKey("TransporteRefId"); cs.ToTable("ClienteTransporte"); }); n*n

            modelBuilder.Conventions.Remove();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }

    }
}