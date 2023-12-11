namespace Infraestrutura.DTOs;

public class TelefoneDTO
{
    public int IdTelefone { get; set; }
    public int NumeroFixo { get; set; }
    public int NumeroCell { get; set; }
    public int DDD_Telefone { get; set; }
    public int DDD_Celular { get; set; }
    public int IdFuncionario { get; set; }
    public FuncionarioDTO? Funcionario { get; set; }
}
