using Core.Interfaces;
using Core.Models;

namespace Infraestrutura.Services;

public class FeriasService : IFeriasService
{
    private readonly IFeriasRepositorySQL _feriasRepositorySQL;
    public FeriasService(IFeriasRepositorySQL feriasRepositorySQL)
    {
        _feriasRepositorySQL = feriasRepositorySQL;
    }
    public async Task<List<FeriasModel>> BuscarFeriasPorIdDoUsuario(int idUsuario)
    {
        try
        {
            return await _feriasRepositorySQL.BuscarFeriasPorIdDoUsuario(idUsuario);
        }
        catch (Exception)
        {

            throw;
        }
    }

    public async Task SolicitarFerias(int idFerias)
    {
        try
        {
            await _feriasRepositorySQL.SolicitarFerias(idFerias);
        }
        catch (Exception)
        {

            throw;
        }
    }
}
