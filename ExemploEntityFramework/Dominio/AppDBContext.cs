using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ExemploEntityFramework.Dominio
{
    public class AppDBContext:DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public AppDBContext() : base(nameOrConnectionString: "exemplo")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            modelBuilder.Conventions.Remove < PluralizingEntitySetNameConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
