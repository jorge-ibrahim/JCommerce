using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCommerce.Dominio.MetaData
{
    public interface IEmpleadoMTD
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
       // [StringLength(200, ErrorMessage = "El campo {0} debe ser menor a {1} caracteres.")]
        [Range(1,9999, ErrorMessage ="El campo {0} debe estar entre {1} y {2}.")]
        int Legajo { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        DateTime FechaIngreso { get; set; }
    }
}
