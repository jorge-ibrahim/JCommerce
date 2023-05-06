using JCommerce.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JCommerce.Infraestructura.Repositorios
{
    public interface IRepositorioGenerico<TEntidad> where TEntidad : class
    {
        int Agregar(TEntidad entidad);
        void Eliminar(TEntidad entidad);
        void Modificar(TEntidad entidad);
        IEnumerable<TEntidad> ObtenerTodos();
        IEnumerable<TEntidad> ObtenerPor(string cadenaBuscar);
        TEntidad ObtenerPorID(int entidadId);
    }
}
