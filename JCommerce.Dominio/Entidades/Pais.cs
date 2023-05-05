using JCommerce.Dominio.MetaData;
using System.ComponentModel.DataAnnotations;

namespace JCommerce.Dominio.Entidades
{
    [MetadataType(typeof(IPaisMTD))]
    public class Pais:EntidadBase
    {
        public string Descripcion { get; set; }

        //Navegacion
        public virtual ICollection<Provincia> NProvincias { get; set; }
    }
}
