using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCommerce.Servicio.Dtos
{
    public class BaseDto
    {
        public int Id { get; set; }
        public bool EstaEliminado { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
