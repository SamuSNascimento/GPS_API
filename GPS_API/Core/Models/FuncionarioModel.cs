namespace Core.Models;

public class FuncionarioModel
{
    public int IdFuncionario { get; set; }
    public string NomeFuncionario { get; set; }
    public string CPF { get; set; }
    public string RG { get; set; }
    public string Cargo { get; set; }
    public double SalarioBase { get; set; }
    public string ContaBancaria { get; set; }
    public UsuarioModel? Usuario { get; set; }
    public List<EnderecoModel>? Enderecos { get; set; }
    public List<FolhaPagamentoModel>? FolhasPagamentos { get; set; }
    public List<TelefoneModel>? Telefones { get; set; }
    public List<FeriasModel>? Ferias { get; set; }
    public List<RegistroPontoModel>? RegistroPonto { get; set; }
}
