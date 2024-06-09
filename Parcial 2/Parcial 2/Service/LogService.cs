using Parcial_2.Service.Interface;
using Parcial_2.Dal;
using Parcial_2.Dal.Entities;

namespace Parcial_2.Service
{
    public class LogService : ILogService
    {
        private readonly IUnitOfWork _unitOfWork;
        public LogService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Usuario> GetUsuarioByUserPass(string user, string pass)
        {
            var usuario = await _unitOfWork.UsuarioRepository.GetByUser(user);
            if (usuario == null)
            {
                return null;
            }
            else if (usuario.Password != pass)
            {
                return null;
            }
            return usuario;
        }
    }
}
