using Core.Models;

namespace Infraestrutura.DTOs;

public class FolhaPagamentoDTO
{
    public int IdFolhaPagemento { get; set; }
    public double SalarioBase { get; set; }
    public double Beneficios { get; set; }
    public double HorasExtras { get; set; }
    public double Adicionais { get; set; }
    public double Deducoes { get; set; }
    public double Impostos { get; set; }
    public double ContribuicoesPrevidenciarias { get; set; }
    public DateTime DataFolhaPagamento { get; set; }
    public int IdFuncionario { get; set; }
    public FuncionarioDTO? Funcionario { get; set; }
    public ICollection<RegistroPontoDTO>? RegistroPonto { get; set; }

    public FolhaPagamentoModel ConverterDTOParaModel(FolhaPagamentoDTO folhaPagamentoDTO)
    {
        return new FolhaPagamentoModel(folhaPagamentoDTO.IdFolhaPagemento, folhaPagamentoDTO.SalarioBase, folhaPagamentoDTO.Beneficios, folhaPagamentoDTO.HorasExtras, folhaPagamentoDTO.Adicionais, folhaPagamentoDTO.Deducoes, folhaPagamentoDTO.Impostos, folhaPagamentoDTO.ContribuicoesPrevidenciarias, folhaPagamentoDTO.DataFolhaPagamento);
    }
}
