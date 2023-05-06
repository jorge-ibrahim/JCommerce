using JCommerce.Dominio.Entidades;
using JCommerce.Infraestructura.Repositorios;
using JCommerce.Servicio.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCommerce.Servicio.Pais
{
    public interface IPaisServicio : IRepositorioGenerico<PaisDto>
    {
        ////Persistencia
        //Task<int> Agregar(PaisDto entidad);
        //Task Modificar(PaisDto entidad);
        //Task Eliminar(int id);
        ////Lectura
        //Task<IEnumerable<PaisDto>> Buscar(string CadenaBuscar);
        //Task<PaisDto> BuscarPorId(int id);
    }
}
