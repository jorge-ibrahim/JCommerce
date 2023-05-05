using JCommerce.Dominio.MetaData;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JCommerce.Dominio.Entidades
{
    [Table("Cliente")]
    [MetadataType(typeof(IClienteMTD))]
    public class Cliente : Persona
    {
        public int? Cuil { get; set; }
        public string? RazonSocial { get; set; }

        //Navegacion

        //public virtual Localidad NLocalidad { get; set; }
    }
}
