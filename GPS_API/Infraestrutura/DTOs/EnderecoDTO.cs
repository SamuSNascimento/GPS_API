namespace Infraestrutura.DTOs;

public class EnderecoDTO
{
    public int IdEndereco { get; set; }
    public string CEP { get; set; }
    public string Rua { get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }
    public int IdFuncionario { get; set; }
    public FuncionarioDTO? Funcionario { get; set; }
}
