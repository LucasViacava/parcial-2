using Parcial_2.Dal.Data;
using Parcial_2.Dal.Repository.Interface;
namespace Parcial_2.Dal
{
    public class UnitOfWork : IUnitOfWork
    {
        public IDiscoRepository DiscoRepository { get; }
        public ICancionRepository CancionRepository { get; }
        public IUsuarioRepository UsuarioRepository { get; }

        private readonly DataContext _context;

        public UnitOfWork(DataContext context,
            IDiscoRepository discoRepository,
            ICancionRepository cancionRepository,
            IUsuarioRepository ussuarioRepository)
        {
            _context = context;
            DiscoRepository = discoRepository;
            CancionRepository = cancionRepository;
            UsuarioRepository = ussuarioRepository;
        }

        public async Task<int> Save()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
