using Core.Models;

namespace Core.Interfaces;

public interface IRegistroPontoService
{
    Task<List<RegistroPontoModel>> BuscarRegistrosDePontoPorIdUsuario(int idUsuario, DateTime dataInicio, DateTime dataFim);
    Task<double> BuscarHorasExtrasPorIdUsuario(int idUsuario);
}
