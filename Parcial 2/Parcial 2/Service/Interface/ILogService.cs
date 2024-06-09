using Parcial_2.Dal.Entities;
namespace Parcial_2.Service.Interface
{
    public interface ILogService
    {
        Task<Usuario> GetUsuarioByUserPass(string user, string pass);
    }
}
