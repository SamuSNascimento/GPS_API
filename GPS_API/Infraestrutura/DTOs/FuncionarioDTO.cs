namespace Infraestrutura.DTOs;

public class FuncionarioDTO
{
    public int IdFuncionario { get; set; }
    public string NomeFuncionario { get; set; }
    public string CPF { get; set; }
    public string RG { get; set; }
    public string Cargo { get; set; }
    public double SalarioBase { get; set; }
    public string ContaBancaria { get; set; }
    public UsuarioDTO? Usuario { get; set; }
    public ICollection<EnderecoDTO>? Enderecos { get; set; }
    public ICollection<FolhaPagamentoDTO>? FolhasPagamentos { get; set; }
    public ICollection<TelefoneDTO>? Telefones { get; set; }
    public ICollection<FeriasDTO>? Ferias { get; set; }
    public ICollection<RegistroPontoDTO>? RegistroPonto { get; set; }
}
