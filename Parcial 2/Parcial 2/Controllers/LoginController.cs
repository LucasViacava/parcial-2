using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Parcial_2.Service.Interface;
using Parcial_2.DTO.Login;

namespace Parcial_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILogService _logService;
        private IConfiguration _configuration;
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogService logService, IConfiguration configuration, ILogger<LoginController> logger)
        {
            _logService = logService;
            _configuration = configuration;
            _logger = logger;
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult<object>> Login(LoginRequestDTO login)
        {
            try
            {
                _logger.LogInformation("POST :: Login");

                var userEntity = await _logService.GetUsuarioByUserPass(login.Username, login.Password);
                if (userEntity != null)
                {
                    var claims = new[]
                    {
                        new Claim(JwtRegisteredClaimNames.Sub,_configuration["Jwt:Subject"]),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                        new Claim("UserId", userEntity.Id.ToString()),
                        new Claim("DisplayName", userEntity.Name),
                        new Claim("UserName", userEntity.UserName),
                    };
                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                    var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                    var token = new JwtSecurityToken(
                        _configuration["Jwt:Issuer"],
                        _configuration["Jwt:Audience"],
                        claims,
                        expires: DateTime.UtcNow.AddMinutes(10),
                        signingCredentials: signIn);

                    return Ok(new JwtSecurityTokenHandler().WriteToken(token));
                }
                else
                {
                    return BadRequest("");
                }
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
