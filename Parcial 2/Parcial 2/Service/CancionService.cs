using AutoMapper;
using Parcial_2.Dal;
using Parcial_2.DTO.Cancion;
using Parcial_2.Service.Interface;
namespace Parcial_2.Service
{
    public class CancionService : ICancionService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CancionService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<CancionResponseDTO>> GetByFilter(CancionFilterRequestDTO request)
        {
            try
            {
                var result = await _unitOfWork.CancionRepository.GetByFilter(request);
                var canciones = _mapper.Map<List<CancionResponseDTO>>(result);
                return canciones;
            } catch (Exception ex)
            {
                return null;
            }
        }
    }
}
