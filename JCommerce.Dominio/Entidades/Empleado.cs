using JCommerce.Dominio.MetaData;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JCommerce.Dominio.Entidades
{
    [Table("Empleado")]
    [MetadataType(typeof(IEmpleadoMTD))]
    public class Empleado : Persona
    {
        public int Legajo { get; set; }
        public DateTime FechaIngreso { get; set; }

        //Navegacion

        //public virtual Localidad NLocalidad { get; set; }
    }
}
