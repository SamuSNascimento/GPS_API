using Core.Models;

namespace Core.Interfaces;

public interface IFeriasService
{
    Task<List<FeriasModel>> BuscarFeriasPorIdDoUsuario(int idUsuario);

    Task SolicitarFerias(int idFerias);
}
