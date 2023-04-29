using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using static JCommerce.Infraestructura.CadenaConexion;
using JCommerce.Dominio.Entidades;

namespace JCommerce.Infraestructura
{
    public class DataContext:DbContext
    {
        public DataContext()
            : base(ObtenerCadenaConexion)
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }

        public IDbSet<Pais> Pais { get; set; }
    }
}
