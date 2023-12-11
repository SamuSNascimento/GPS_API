using Core.Interfaces;
using Core.Models;

namespace Infraestrutura.Services;

public class RegistroPontoService : IRegistroPontoService
{
    private readonly IRegistroPontoRepositorySQL _registroPontoRepositorySQL;
    public RegistroPontoService(IRegistroPontoRepositorySQL registroPontoRepositorySQL)
    {
        _registroPontoRepositorySQL = registroPontoRepositorySQL;
    }
    public async Task<double> BuscarHorasExtrasPorIdUsuario(int idUsuario)
    {
        try
        {
            return await _registroPontoRepositorySQL.BuscarHorasExtrasPorIdUsuario(idUsuario);
        }
        catch (Exception)
        {

            throw;
        }
    }

    public async Task<List<RegistroPontoModel>> BuscarRegistrosDePontoPorIdUsuario(int idUsuario, DateTime dataInicio, DateTime dataFim)
    {
        try
        {
            return await _registroPontoRepositorySQL.BuscarRegistrosDePontoPorIdUsuario(idUsuario, dataInicio, dataFim);
        }
        catch (Exception)
        {
            throw;
        }
    }
}
