using JCommerce.Dominio.MetaData;
using System.ComponentModel.DataAnnotations;

namespace JCommerce.Dominio.Entidades
{
    [MetadataType(typeof(IProvinciaMTD))]
    public class Provincia:EntidadBase
    {
        //Propiedades

        public string Descripcion { get; set; }

        //Navegacion

        public virtual Pais NPais { get; set; }
        public virtual ICollection<Localidad> NLocalidades { get; set; }
    }    
}

