namespace Core.Models;

public class TelefoneModel
{
    public int IdTelefone { get; set; }
    public int NumeroFixo { get; set; }
    public int NumeroCell { get; set; }
    public int DDD_Telefone { get; set; }
    public int DDD_Celular { get; set; }
    public FuncionarioModel? Funcionario { get; set; }
}
