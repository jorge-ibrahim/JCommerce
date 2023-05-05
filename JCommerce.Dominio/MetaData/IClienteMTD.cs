using System.ComponentModel.DataAnnotations;

namespace JCommerce.Dominio.MetaData
{
    public interface IClienteMTD
    {
        //[StringLength(200, ErrorMessage = "El campo {0} debe ser menor a {1} caracteres.")]
        int Cuil { get; set; }

        [StringLength(200, ErrorMessage = "El campo {0} debe ser menor a {1} caracteres.")]
        string? RazonSocial { get; set; }
    }
}
