using JCommerce.Dominio.MetaData;
using System.ComponentModel.DataAnnotations;

namespace JCommerce.Dominio.Entidades
{
    [MetadataType(typeof(IPersonaMTD))]
    public class Persona : EntidadBase
    {
        public int LocalidadId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Documento { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string? Email { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public byte[]? Foto { get; set; }

        //Navegacion
        public virtual Localidad NLocalidad { get; set; }
    }
}
