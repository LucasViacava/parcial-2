using AutoMapper;
using Parcial_2.Dal;
using Parcial_2.DTO.Disco;
using Parcial_2.Service.Interface;
using Parcial_2.Dal.Entities;

namespace Parcial_2.Service
{
    public class DiscoService : IDiscoService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public DiscoService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<DiscoResponseDTO> Create(DiscoCreateRequestDTO request)
        {
            var discoEntity = _mapper.Map<Disco>(request);
            await _unitOfWork.DiscoRepository.Add(discoEntity);
            var result = await _unitOfWork.Save();
            if (result == 0)
            {
                return null;
            }
            var resultDisco = _mapper.Map<DiscoResponseDTO>(discoEntity);
            return resultDisco;
        }

        public async Task<DiscoResponseDTO> Update(string SKU, DiscoUpdateRequestDTO request)
        {
            var disco = await _unitOfWork.DiscoRepository.GetBySKU(SKU);
            if (disco == null)
            {
                return null;
            }
            disco.Nombre = request.Titulo ?? disco.Nombre;
            disco.Genero = request.Genero ?? disco.Genero;
            if (request.FechaLanzamiento != null)
            {
                disco.FechaLanzamiento = (DateTime) request.FechaLanzamiento;
            }
            disco.Banda = request.Banda ?? disco.Banda;
            if (request.CantidadVendidas != null)
            {
                disco.UnidadesVendidas = (int) request.CantidadVendidas;
            }
            _unitOfWork.DiscoRepository.Edit(disco);
            if (await _unitOfWork.Save() == 0)
            {
                return null;
            }
            var newDisco = await _unitOfWork.DiscoRepository.GetIdFull(disco.Id);
            var returnDisco = _mapper.Map<DiscoResponseDTO>(newDisco);
            return returnDisco;
        }
        public async Task<List<DiscoResponseDTO>> GetTopFive()
        {
            var result = await _unitOfWork.DiscoRepository.GetTopFiveDisks();
            var discos = _mapper.Map<List<DiscoResponseDTO>>(result);
            return discos;
        }
        public async Task<List<DiscoResponseDTO>> GetByFilter(DiscoFilterRequestDTO filter)
        {
            var result = await _unitOfWork.DiscoRepository.GetByFilter(filter);
            var discos = _mapper.Map<List<DiscoResponseDTO>>(result);
            return discos;
        }
    }
}
