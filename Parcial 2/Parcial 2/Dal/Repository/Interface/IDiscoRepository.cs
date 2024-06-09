using Parcial_2.Dal.Entities;
using Parcial_2.DTO.Disco;
namespace Parcial_2.Dal.Repository.Interface
{
    public interface IDiscoRepository : IRepository<Disco>
    {
        Task<List<Disco>> GetTopFiveDisks();
        Task<List<Disco>> GetByFilter(DiscoFilterRequestDTO filter);
        Task<Disco> GetBySKU(string SKU);
        Task<Disco> GetIdFull(int Id);

    }
}
