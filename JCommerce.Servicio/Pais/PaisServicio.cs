using JCommerce.Infraestructura;
using JCommerce.Servicio.Dtos;
using Microsoft.EntityFrameworkCore;

namespace JCommerce.Servicio.Pais
{
    public class PaisServicio : IPaisServicio
    {
        public async Task<int> Agregar(PaisDto entidad)
        {
            using(var context = new DataContext())
            {
                var entidadNueva = new JCommerce.Dominio.Entidades.Pais{
                    Nombre = entidad.Nombre,
                    EstaEliminado = false
                };

                context.Pais.Add(entidadNueva);
                await context.SaveChangesAsync();
                return entidadNueva.Id;
            }
        }

        public async Task<IEnumerable<PaisDto>> Buscar(string CadenaBuscar)
        {
            using(var context = new DataContext())
            {
                return await context.Pais.AsNoTracking().Where(x => x.EstaEliminado ==
                false && x.Nombre == CadenaBuscar).Select(x => new PaisDto
                {
                    Id = x.Id,
                    Nombre = x.Nombre,
                    EstaEliminado = x.EstaEliminado,
                    RowVersion = x.RowVersion
                }).ToListAsync();
            }
        }

        public Task<PaisDto> BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public async Task Eliminar(int id)
        {
            using(var context = new DataContext())
            {
                var entidadEliminar = await context.Pais.FirstOrDefaultAsync(x => x.Id == id);

                if (entidadEliminar == null)
                    throw new Exception("Ocurrio un Error al obtener los datos.");
                //borrado logico
                entidadEliminar.EstaEliminado = true;

                //borrado fisico
               // context.Pais.Remove(entidadEliminar);

                await context.SaveChangesAsync();
            }
        }

        public async Task Modificar(PaisDto entidad)
        {
            using(var context = new DataContext())
            {
                var entidadModificar = await context.Pais.FirstOrDefaultAsync(x => x.Id == entidad.Id);

                if (entidadModificar == null)
                    throw new Exception("Ocurrio un Error al obtener los datos.");

                entidadModificar.Nombre = entidad.Nombre;
                await context.SaveChangesAsync();
            }
        }
    }
}
