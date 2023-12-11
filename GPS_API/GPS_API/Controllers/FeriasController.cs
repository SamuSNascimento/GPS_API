using Core.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GPS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeriasController : ControllerBase
    {
        private readonly IFeriasService _feriasService;

        public FeriasController(IFeriasService feriasService)
        {
            _feriasService = feriasService;
        }
        [HttpGet("{idUsuario}")]
        public async Task<ActionResult<List<FeriasModel>>> BuscarFeriasPorIdDoUsuario(int idUsuario)
        {
            try
            {
                var ferias = await _feriasService.BuscarFeriasPorIdDoUsuario(idUsuario);
                return Ok(ferias);
            }
            catch (Exception)
            {

                return BadRequest("Erro de comunicação com o servidor");
            }
        }

        [HttpGet("SolicitarFerias/{idFerias}")]
        public async Task<ActionResult> SolicitarFerias(int idFerias)
        {
            try
            {
                await _feriasService.SolicitarFerias(idFerias);
                return Ok("Férias solicitadas");
            }
            catch (Exception)
            {

                return BadRequest("Férias já solicitada");
            }
        }
    }
}
