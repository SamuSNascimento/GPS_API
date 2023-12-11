using Core.Models;

namespace Core.Interfaces;

public interface IFeriasRepositorySQL
{
    Task<List<FeriasModel>> BuscarFeriasPorIdDoUsuario(int idUsuario);

    Task SolicitarFerias(int idFerias);
}
