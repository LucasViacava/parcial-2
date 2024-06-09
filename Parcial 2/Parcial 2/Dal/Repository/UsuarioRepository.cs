using Parcial_2.Dal.Repository.Interface;
using Parcial_2.Dal.Data;
using Parcial_2.Dal.Entities;
using Microsoft.EntityFrameworkCore;

namespace Parcial_2.Dal.Repository
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(DataContext context) : base(context)
        {

        }

        public async Task<Usuario> GetByUser(string name)
        {
            var usuario = await _context.Usuarios
                .Where(x => x.UserName == name)
                .FirstOrDefaultAsync();
            return usuario;
        }
    }
}
