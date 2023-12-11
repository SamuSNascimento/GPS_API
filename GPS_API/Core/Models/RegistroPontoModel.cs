namespace Core.Models;

public class RegistroPontoModel
{
    public RegistroPontoModel(int idRegistroPonto, DateTime dataHoraEntrada, DateTime dataHoraSaida, double horasExtras, int faltas, int atrasos)
    {
        IdRegistroPonto = idRegistroPonto;
        DataHoraEntrada = dataHoraEntrada;
        DataHoraSaida = dataHoraSaida;
        HorasExtras = horasExtras;
        Faltas = faltas;
        Atrasos = atrasos;
    }

    public int IdRegistroPonto { get; set; }
    public DateTime DataHoraEntrada { get; set; }
    public DateTime DataHoraSaida { get; set; }
    public double HorasExtras { get; set; }
    public int Faltas { get; set; }
    public int Atrasos { get; set; }
    public FuncionarioModel? Funcionario { get; set; }
    public FolhaPagamentoModel? FolhaPagamento { get; set; }
}
