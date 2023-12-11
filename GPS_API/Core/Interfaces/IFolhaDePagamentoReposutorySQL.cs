using Core.Models;

namespace Core.Interfaces;

public interface IFolhaDePagamentoReposutorySQL
{
    Task<List<FolhaPagamentoModel>> BuscarFolhaDePagamentoPorIdDoUsuario(int idUsuario);
}
