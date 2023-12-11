using Core.Interfaces;
using Core.Models;
using Infraestrutura.DataBaseContext;
using Microsoft.EntityFrameworkCore;

namespace Infraestrutura.Repositories;

public class FeriasRepositorySQL : IFeriasRepositorySQL
{
    private readonly ApplicationDbContext _dbContext;

    public FeriasRepositorySQL(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<List<FeriasModel>> BuscarFeriasPorIdDoUsuario(int idUsuario)
    {
        try
        {
            var ferias = await _dbContext.Ferias.Where(x => x.IdFuncionario == idUsuario).ToListAsync();

            List<FeriasModel> feriasModel = new();
            foreach (var feriasDto in ferias)
            {
                feriasModel.Add(feriasDto.ConverterDTOParaModel(feriasDto));
            }

            return feriasModel;
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
            var ferias = await _dbContext.Ferias.Where(x => x.IdFerias == idFerias).FirstOrDefaultAsync();
            ferias.Status = true;

            _dbContext.Update(ferias);
            _dbContext.SaveChanges();
        }
        catch (Exception)
        {

            throw;
        }
    }
}
