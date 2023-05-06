using JCommerce.Infraestructura;
using JCommerce.Infraestructura.Migrations;
using JCommerce.Infraestructura.Repositorios;
using JCommerce.Servicio.Dtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq.Expressions;

namespace JCommerce.Servicio.Pais
{
    public class PaisServicio : IPaisServicio
    {
       
        
        public int Agregar(PaisDto entidad)
        {
            using (var context = new DataContext())
            {
                var entidadNueva = new JCommerce.Dominio.Entidades.Pais
                {
                    Descripcion = entidad.Nombre,
                    EstaEliminado = false
                };

                context.Pais.Add(entidadNueva);
                context.SaveChanges();
                return entidadNueva.Id;
            }
        }

        public void Eliminar(PaisDto entidad)
        {
            using(var context = new DataContext())
            {
                var entidadEliminar = context.Pais.FirstOrDefault(x => x.Id == entidad.Id);

                entidadEliminar.EstaEliminado = true;

                context.SaveChanges();
            }
        }

        public void Modificar(PaisDto entidad)
        {
            using (var context = new DataContext())
            {
                var entidadModificar = context.Pais.FirstOrDefault(x => x.Id == entidad.Id);

                if (entidadModificar == null)
                    throw new Exception("Ocurrio un Error al obtener los datos.");

                entidadModificar.Descripcion = entidad.Nombre;
                context.SaveChanges();
            }
        }

        public IEnumerable<PaisDto> ObtenerPor(string cadenaBuscar)
        {
            using (var context = new DataContext())
            {
                return context.Pais.AsNoTracking().Where(x => !x.EstaEliminado 
                && (x.Descripcion.Contains(cadenaBuscar)
                )).Select(x => new PaisDto
                {
                    Id = x.Id,
                    Nombre = x.Descripcion,
                    EstaEliminado = x.EstaEliminado,
                    RowVersion = x.RowVersion
                }).ToList();
            }
        }

        public PaisDto ObtenerPorID(int entidadId)
        {
            using(var context = new DataContext())
            {
                var entidadEliminar = context.Pais.AsNoTracking().Include(x => x.NProvincias)
                    .Where(x => !x.EstaEliminado)
                    .Select(x=> new PaisDto
                    {
                        Id = x.Id,
                        Nombre = x.Descripcion,
                        EstaEliminado = x.EstaEliminado,
                        RowVersion = x.RowVersion,
                        
                    }).FirstOrDefault(x => x.Id == entidadId);

                return entidadEliminar;
            }
        }

        public IEnumerable<PaisDto> ObtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
