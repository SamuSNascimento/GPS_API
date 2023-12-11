using Core.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace GPS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService _usuarioService;
        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet("BuscarUsuario")]
        public async Task<ActionResult<UsuarioModel>> BuscarUsuarioPeloEmailSenha([FromQuery] string email, string senha)
        {
            try
            {
                var usuario = await _usuarioService.BuscarUsuarioPeloEmailSenha(email, senha);

                return Ok(usuario);

            }
            catch (Exception)
            {
                return BadRequest("Email ou senha incorretos");
            }
        }

        [HttpGet("AlterarSenha")]
        public async Task<ActionResult> AlterarSenha([FromQuery] int idUsuario, string novaSenha)
        {
            try
            {
                await _usuarioService.AlterarSenha(idUsuario, novaSenha);
                return Ok("Senha alterada com sucesso");

            }
            catch (Exception)
            {
                return BadRequest("Falha de comunicação com o servidor");
            }
        }

    }
}
