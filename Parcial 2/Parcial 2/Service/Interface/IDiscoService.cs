using Parcial_2.DTO.Disco;
namespace Parcial_2.Service.Interface
{
    public interface IDiscoService
    {
        Task<DiscoResponseDTO> Create(DiscoCreateRequestDTO discoRequest);
        Task<DiscoResponseDTO> Update(string SKU, DiscoUpdateRequestDTO discoRequest);
        Task<List<DiscoResponseDTO>> GetTopFive();
        Task<List<DiscoResponseDTO>> GetByFilter(DiscoFilterRequestDTO discoRequest);
    }
}
