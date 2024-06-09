using Parcial_2.Dal.Repository.Interface;
using Parcial_2.Dal.Data;
using Parcial_2.Dal.Entities;
using Parcial_2.DTO.Cancion;
using Microsoft.EntityFrameworkCore;

namespace Parcial_2.Dal.Repository
{
    public class CancionRepository : Repository<Cancion>, ICancionRepository
    {
        public CancionRepository(DataContext context) : base(context)
        {

        }
        public async Task<List<Cancion>> GetByFilter(CancionFilterRequestDTO request)
        {
            try
            {
                var query = _context.Canciones
                    .Include(x => x.Disco)
                    .AsQueryable();

                if (!string.IsNullOrEmpty(request.NombreCancion))
                {
                    query = query.Where(x => x.TituloCancion.Contains(request.NombreCancion));
                }

                if (request.DuracionCancion.HasValue)
                {
                    query = query.Where(x => x.TiempoDuracion == request.DuracionCancion);
                }

                if (!string.IsNullOrEmpty(request.Banda))
                {
                    query = query.Where(x => x.Disco.Banda.Contains(request.Banda));
                }

                var result = await query.ToListAsync();

                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}
