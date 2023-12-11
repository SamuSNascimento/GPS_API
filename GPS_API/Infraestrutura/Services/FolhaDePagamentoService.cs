using Core.Interfaces;
using Core.Models;

namespace Infraestrutura.Services;

public class FolhaDePagamentoService : IFolhaDePagamentoService
{
    private readonly IFolhaDePagamentoReposutorySQL _folhaDePagamentoReposutorySQL;
    public FolhaDePagamentoService(IFolhaDePagamentoReposutorySQL folhaDePagamentoReposutorySQL)
    {
        _folhaDePagamentoReposutorySQL = folhaDePagamentoReposutorySQL;
    }
    public async Task<List<FolhaPagamentoModel>> BuscarFolhaDePagamentoPorIdDoUsuario(int idUsuario)
    {
        try
        {
            return await _folhaDePagamentoReposutorySQL.BuscarFolhaDePagamentoPorIdDoUsuario(idUsuario);
        }
        catch (Exception)
        {

            throw;
        }
    }
}
