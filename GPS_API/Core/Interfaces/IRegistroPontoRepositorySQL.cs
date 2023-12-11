using Core.Models;

namespace Core.Interfaces;

public interface IRegistroPontoRepositorySQL
{
    Task<List<RegistroPontoModel>> BuscarRegistrosDePontoPorIdUsuario(int idUsuario, DateTime dataInicio, DateTime dataFim);
    Task<double> BuscarHorasExtrasPorIdUsuario(int idUsuario);
}
