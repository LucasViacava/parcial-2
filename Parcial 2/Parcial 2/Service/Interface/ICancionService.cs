using Parcial_2.DTO.Cancion;
namespace Parcial_2.Service.Interface
{
    public interface ICancionService
    {
        Task<List<CancionResponseDTO>> GetByFilter(CancionFilterRequestDTO cancionRequest);
    }
}
