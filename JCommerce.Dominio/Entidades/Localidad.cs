using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCommerce.Dominio.Entidades
{
    public class Localidad : EntidadBase
    {
        public string Descripcion { get; set; }
        public int ProvinciaId { get; set; }

        //Navegacion

        public virtual Provincia NProvincia { get; set; }

        public virtual ICollection<Empleado> NEmpleados { get; set; }
        public virtual ICollection<Cliente> NClientes { get; set; }
    }
}
