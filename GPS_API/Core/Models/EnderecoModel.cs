namespace Core.Models;

public class EnderecoModel
{
    public int IdEndereco { get; set; }
    public string CEP { get; set; }
    public string Rua { get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }
    public FuncionarioModel? Funcionario { get; set; }
}