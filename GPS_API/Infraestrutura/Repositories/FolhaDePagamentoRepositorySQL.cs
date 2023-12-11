using Core.Interfaces;
using Core.Models;
using Infraestrutura.DataBaseContext;
using Microsoft.EntityFrameworkCore;

namespace Infraestrutura.Repositories;

public class FolhaDePagamentoRepositorySQL : IFolhaDePagamentoReposutorySQL
{
    private readonly ApplicationDbContext _dbContext;

    public FolhaDePagamentoRepositorySQL(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<List<FolhaPagamentoModel>> BuscarFolhaDePagamentoPorIdDoUsuario(int idUsuario)
    {
        try
        {
            var folhasDePagamento = await _dbContext.FolhaPagamento.Where(x => x.IdFuncionario == idUsuario).ToListAsync();

            List<FolhaPagamentoModel> folhaPagamentoModel = new();
            foreach (var folhasDePagamentoDto in folhasDePagamento)
            {
                folhaPagamentoModel.Add(folhasDePagamentoDto.ConverterDTOParaModel(folhasDePagamentoDto));
            }

            return folhaPagamentoModel;
        }
        catch (Exception)
        {

            throw;
        }
    }
}
