using Core.Models;

namespace Infraestrutura.DTOs;

public class UsuarioDTO
{
    public int IdUsuario { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public int IdFuncionario { get; set; }
    public FuncionarioDTO? Funcionario { get; set; }
    public int NivelDeAcesso { get; set; }

    public UsuarioModel ConverterDTOParaModel(UsuarioDTO usuarioDTO)
    {
        return new UsuarioModel(usuarioDTO.IdUsuario, usuarioDTO.UserName, usuarioDTO.Email, usuarioDTO.Password, usuarioDTO.NivelDeAcesso);
    }
}