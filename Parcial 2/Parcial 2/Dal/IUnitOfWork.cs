using Parcial_2.Dal.Repository.Interface;
namespace Parcial_2.Dal
{
    public interface IUnitOfWork : IDisposable
    {
        IDiscoRepository DiscoRepository { get; }
        IUsuarioRepository UsuarioRepository { get; }
        ICancionRepository CancionRepository { get; }
        Task<int> Save();
    }
}
