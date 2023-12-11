using Core.Models;

namespace Infraestrutura.DTOs;

public class FeriasDTO
{
    public int IdFerias { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
    public string TipoFerias { get; set; }
    public bool Status { get; set; }
    public int IdFuncionario { get; set; }
    public FuncionarioDTO? Funcionario { get; set; }

    public FeriasModel ConverterDTOParaModel(FeriasDTO feriasDTO)
    {
        return new FeriasModel(feriasDTO.IdFerias, feriasDTO.DataInicio, feriasDTO.DataFim, feriasDTO.TipoFerias, feriasDTO.Status);
    }
}
