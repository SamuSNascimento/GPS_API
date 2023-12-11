namespace Core.Models;

public class FeriasModel
{
    public FeriasModel(int idFerias, DateTime dataInicio, DateTime dataFim, string tipoFerias, bool status)
    {
        IdFerias = idFerias;
        DataInicio = dataInicio;
        DataFim = dataFim;
        TipoFerias = tipoFerias;
        Status = status;
    }
    public FeriasModel()
    {

    }
    public int IdFerias { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
    public string TipoFerias { get; set; }
    public bool Status { get; set; }
    public FuncionarioModel? Funcionario { get; set; }
}
