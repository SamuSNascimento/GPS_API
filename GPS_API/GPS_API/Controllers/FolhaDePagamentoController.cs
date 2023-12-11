using Core.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GPS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FolhaDePagamentoController : ControllerBase
    {

        private readonly IFolhaDePagamentoService _folhaDePagamentoService;

        public FolhaDePagamentoController(IFolhaDePagamentoService folhaDePagamentoService)
        {
            _folhaDePagamentoService = folhaDePagamentoService;
        }

        [HttpGet("{idUsuario}")]
        public async Task<ActionResult<List<FolhaPagamentoModel>>> BuscarFolhaDePagamentoPorIdDoUsuario(int idUsuario)
        {
            try
            {
                var folhaDePagamento = await _folhaDePagamentoService.BuscarFolhaDePagamentoPorIdDoUsuario(idUsuario);
                return Ok(folhaDePagamento);
            }
            catch (Exception)
            {

                return BadRequest("Falha de comunicação com o servidor");
            }
        }
    }
}
