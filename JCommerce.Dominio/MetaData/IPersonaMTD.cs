using System.ComponentModel.DataAnnotations;

namespace JCommerce.Dominio.MetaData
{
    public interface IPersonaMTD
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        int LocalidadId { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(200, ErrorMessage = "El campo {0} debe ser menor a {1} caracteres.")]
        string Nombre { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(200, ErrorMessage ="El campo {0} debe ser menor a {1} caracteres.")]
        string Apellido { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(8, ErrorMessage = "El campo {0} debe ser menor a {1} caracteres.")]
        string Documento { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(300, ErrorMessage = "El campo {0} debe ser menor a {1} caracteres.")]
        string Domicilio { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(11, ErrorMessage = "El campo {0} debe ser menor a {1} caracteres.")]
        string Telefono { get; set; }

        [DataType(DataType.EmailAddress)]//verifica que el formato sea de un email
        [StringLength(100, ErrorMessage = "El campo {0} debe ser menor a {1} caracteres.")]
        string? Email { get; set; }

        [DataType(DataType.Date)]
        DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage ="El campo {0} es obligatorio.")]
        byte[]? Foto { get; set; }
    }
}
