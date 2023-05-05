using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCommerce.Dominio.Entidades
{
    public class EntidadBase
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="El campo {0} es obligatorio.")]
        [DefaultValue(false)]
        public bool EstaEliminado { get; set; }

        [Timestamp]//activa la concurrencia
        public byte[]? RowVersion { get; set; }
    }
}
