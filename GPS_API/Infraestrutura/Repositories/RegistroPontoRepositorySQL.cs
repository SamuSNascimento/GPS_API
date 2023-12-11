using Core.Interfaces;
using Core.Models;
using Infraestrutura.DataBaseContext;
using Microsoft.EntityFrameworkCore;

namespace Infraestrutura.Repositories;

public class RegistroPontoRepositorySQL : IRegistroPontoRepositorySQL
{
    private readonly ApplicationDbContext _dbContext;

    public RegistroPontoRepositorySQL(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<double> BuscarHorasExtrasPorIdUsuario(int idUsuario)
    {
        try
        {
            var horasExtras = await _dbContext.RegistroPonto.Where(x => x.IdFuncionario == idUsuario).Select(x => x.HorasExtras).ToListAsync();

            double totalDeHoras = 0;

            foreach (var item in horasExtras)
            {
                totalDeHoras += item;
            }

            return totalDeHoras;
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
            var registrosDePonto = await _dbContext.RegistroPonto
                .Where(x => x.IdFuncionario == idUsuario
                && x.DataHoraEntrada >= dataInicio
                && x.DataHoraSaida <= dataFim).ToListAsync();

            List<RegistroPontoModel> registroPontoModel = new();

            foreach (var registrosDePontoDTO in registrosDePonto)
            {
                registroPontoModel.Add(registrosDePontoDTO.ConverterDTOParaModel(registrosDePontoDTO));
            }

            return registroPontoModel;
        }
        catch (Exception)
        {
            throw;
        }
    }
}
