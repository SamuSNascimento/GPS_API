using Core.Models;

namespace Infraestrutura.DTOs;

public class RegistroPontoDTO
{
    public int IdRegistroPonto { get; set; }
    public DateTime DataHoraEntrada { get; set; }
    public DateTime DataHoraSaida { get; set; }
    public double HorasExtras { get; set; }
    public int Faltas { get; set; }
    public int Atrasos { get; set; }
    public int IdFuncionario { get; set; }
    public FuncionarioDTO? Funcionario { get; set; }
    public int IdFolhaDePagamento { get; set; }
    public FolhaPagamentoDTO? FolhaPagamento { get; set; }

    public RegistroPontoModel ConverterDTOParaModel(RegistroPontoDTO registroPontoDTO)
    {
        return new RegistroPontoModel(registroPontoDTO.IdRegistroPonto, registroPontoDTO.DataHoraEntrada, registroPontoDTO.DataHoraSaida, registroPontoDTO.HorasExtras, registroPontoDTO.Faltas, registroPontoDTO.Atrasos);
    }
}
