using Core.Models;

namespace Core.Interfaces;

public interface IFolhaDePagamentoService
{
    Task<List<FolhaPagamentoModel>> BuscarFolhaDePagamentoPorIdDoUsuario(int idUsuario);
}
