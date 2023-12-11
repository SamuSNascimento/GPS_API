namespace Core.Models;

public class FolhaPagamentoModel
{
    public FolhaPagamentoModel(int idFolhaPagemento, double salarioBase, double beneficios, double horasExtras, double adicionais, double deducoes, double impostos, double contribuicoesPrevidenciarias, DateTime dataFolhaPagamento)
    {
        IdFolhaPagemento = idFolhaPagemento;
        SalarioBase = salarioBase;
        Beneficios = beneficios;
        HorasExtras = horasExtras;
        Adicionais = adicionais;
        Deducoes = deducoes;
        Impostos = impostos;
        ContribuicoesPrevidenciarias = contribuicoesPrevidenciarias;
        DataFolhaPagamento = dataFolhaPagamento;
    }

    public FolhaPagamentoModel()
    {

    }

    public int IdFolhaPagemento { get; set; }
    public double SalarioBase { get; set; }
    public double Beneficios { get; set; }
    public double HorasExtras { get; set; }
    public double Adicionais { get; set; }
    public double Deducoes { get; set; }
    public double Impostos { get; set; }
    public double ContribuicoesPrevidenciarias { get; set; }
    public DateTime DataFolhaPagamento { get; set; }
    public FuncionarioModel? Funcionario { get; set; }
    public List<RegistroPontoModel>? RegistroPonto { get; set; }

}
