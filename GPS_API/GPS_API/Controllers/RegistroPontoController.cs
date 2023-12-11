using Core.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GPS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistroPontoController : ControllerBase
    {
        private readonly IRegistroPontoService _registroPontoService;
        public RegistroPontoController(IRegistroPontoService registroPontoService)
        {
            _registroPontoService = registroPontoService;
        }

        [HttpGet]
        public async Task<ActionResult<List<RegistroPontoModel>>> BuscarRegistrosDePontoPorIdUsuario([FromQuery] int idUsuario, DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                var registrosDePonto = await _registroPontoService.BuscarRegistrosDePontoPorIdUsuario(idUsuario, dataInicio, dataFim);
                return Ok(registrosDePonto);
            }
            catch (Exception)
            {
                return BadRequest("Erro de comunicação com o servidor");
            }
        }

        [HttpGet("BuscarHorasExtrasPorIdUsuario/{idUsuario}")]
        public async Task<ActionResult<double>> BuscarHorasExtrasPorIdUsuario(int idUsuario)
        {
            try
            {
                var totalDeHoras = await _registroPontoService.BuscarHorasExtrasPorIdUsuario(idUsuario);
                return Ok(totalDeHoras);
            }
            catch (Exception)
            {
                return BadRequest("Erro de comunicação com o servidor");
            }
        }
    }
}
