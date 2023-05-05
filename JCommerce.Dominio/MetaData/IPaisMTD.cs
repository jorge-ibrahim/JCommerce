using System.ComponentModel.DataAnnotations;

namespace JCommerce.Dominio.MetaData
{
    public interface IPaisMTD
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(200, ErrorMessage = "El campo {0} debe ser menor a {1} caracteres.")]
        string Descripcion { get; set; }
    }
}
