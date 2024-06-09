using Parcial_2.Dal.Entities;

namespace Parcial_2.Dal.Repository.Interface
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        Task<Usuario> GetByUser(string name);
    }
}
