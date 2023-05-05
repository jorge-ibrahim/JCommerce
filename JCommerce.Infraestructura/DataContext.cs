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
            Configuration.LazyLoadingEnabled = false;//no me traigas nada que no te pida saca las mochila
            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //NO borra en cascada si borro un pais borra las provincias y localidades asociadas.
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            //NO pluralise en nombre de las tablas
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }

        public IDbSet<Pais> Pais { get; set; }
        public IDbSet<Provincia> Provincia { get; set; }
        public IDbSet<Localidad> Localidad { get; set; }
        public IDbSet<Persona> Persona { get; set; }
        public IDbSet<Cliente> Cliente { get; set; }
        public IDbSet<Empleado> Empleado { get; set; }
    }
}
