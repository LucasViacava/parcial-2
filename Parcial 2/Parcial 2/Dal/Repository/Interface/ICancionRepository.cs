using Parcial_2.Dal.Entities;
using Parcial_2.DTO.Cancion;

namespace Parcial_2.Dal.Repository.Interface
{
    public interface ICancionRepository : IRepository<Cancion>
    {
        Task<List<Cancion>> GetByFilter(CancionFilterRequestDTO filter);
    }
}
