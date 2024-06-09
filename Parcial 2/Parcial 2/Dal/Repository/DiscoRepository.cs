using Parcial_2.Dal.Repository.Interface;
using Parcial_2.Dal.Data;
using Parcial_2.Dal.Entities;
using Parcial_2.DTO.Disco;
using Microsoft.EntityFrameworkCore;

namespace Parcial_2.Dal.Repository
{
    public class DiscoRepository : Repository<Disco>, IDiscoRepository
    {
        public DiscoRepository(DataContext context) : base(context) 
        { 

        }

        public async Task<List<Disco>> GetTopFiveDisks()
        {
            try
            {
                var result = await _context.Discos
                    .OrderByDescending(x => x.UnidadesVendidas)
                    .Take(5)
                    .ToListAsync();
                return result;
            } catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<List<Disco>> GetByFilter(DiscoFilterRequestDTO request)
        {
            try
            {
                var query = _context.Discos
                    .AsQueryable();

                if (!string.IsNullOrEmpty(request.Genero))
                {
                    query = query.Where(x => x.Genero.Contains(request.Genero));
                }

                if (!string.IsNullOrEmpty(request.Banda))
                {
                    query = query.Where(x => x.Banda.Contains(request.Banda));
                }

                if (request.CantidadVendida.HasValue)
                {
                    query = query.Where(x => x.UnidadesVendidas == request.CantidadVendida);
                }

                if (!string.IsNullOrEmpty(request.TituloDisco))
                {
                    query = query.Where(x => x.Nombre.Contains(request.TituloDisco));
                }

                var result = await query.ToListAsync();

                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }



        public async Task<Disco> GetBySKU(string SKU)
        {
            var disco = await _context.Discos.Where(x => x.SKU == SKU).SingleOrDefaultAsync();
            return disco;
        }
        public async Task<Disco> GetIdFull(int Id)
        {
            var result = await _context.Discos
                .Where (a => a.Id == Id)
                .SingleOrDefaultAsync();
            return result;
        }
    }
}
