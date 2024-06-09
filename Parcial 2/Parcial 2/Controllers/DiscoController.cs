using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Parcial_2.DTO.Disco;
using Parcial_2.Service.Interface;

namespace Parcial_2.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class DiscoController : ControllerBase
    {
        private readonly ILogger<DiscoController> _logger;
        private readonly IDiscoService _service;

        public DiscoController(IDiscoService discoService, ILogger<DiscoController> logger)
        {
            _service = discoService;
            _logger = logger;
        }

        [HttpGet("GetTopFiveDisks")]
        [AllowAnonymous]
        public async Task<ActionResult<DiscoResponseDTO>> GetTopFive()
        {
            try
            {
                var result = await _service.GetTopFive();
                if (result.Count == 0)
                {
                    return NoContent();
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in GetTopFiveDisks");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("GetDisksByFilter")]
        [AllowAnonymous]
        public async Task<ActionResult<List<DiscoResponseDTO>>> GetByFilter([FromQuery] DiscoFilterRequestDTO request)
        {
            try
            {
                var result = await _service.GetByFilter(request);
                if (result.Count == 0)
                {
                    return NoContent();
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in GetDisksByFilter");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPost("Create")]
        public async Task<ActionResult<bool>> Create([FromQuery] DiscoCreateRequestDTO request)
        {
            _logger.LogInformation("POST :: Create");
            try
            {
                var result = await _service.Create(request);
                if (result != null)
                {
                    return Ok(true);
                }
                return BadRequest(false);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating disco");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPut("Update/{SKU}")]
        public async Task<ActionResult<bool>> Update(string SKU, DiscoUpdateRequestDTO request)
        {
            _logger.LogInformation("PUT :: Update");
            try
            {
                var result = await _service.Update(SKU, request);
                if (result != null)
                {
                    return Ok(true);
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error updating disco with SKU: {SKU}");
                return StatusCode(500, "Internal server error");
            }
        }
    }

}

