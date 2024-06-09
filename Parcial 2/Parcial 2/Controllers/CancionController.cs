using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Parcial_2.DTO.Cancion;
using Parcial_2.Service.Interface;

namespace Parcial_2.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class CancionController : ControllerBase
    {
        private readonly ILogger<CancionController> _logger;
        private readonly ICancionService _service;

        public CancionController(ICancionService cancionService, ILogger<CancionController> logger)
        {
            _service = cancionService;
            _logger = logger;
        }
        [HttpGet("GetSongsByFilter")]
        [AllowAnonymous]
        public async Task<ActionResult<List<CancionResponseDTO>>> GetByFilter([FromQuery] CancionFilterRequestDTO filter)
        {
            _logger.LogInformation("Song ::: GetByFilter");
            var result = await _service.GetByFilter(filter);
            if (result.Count == 0)
            {
                return NoContent();
            }
            return Ok(result);
        }
    }
}
