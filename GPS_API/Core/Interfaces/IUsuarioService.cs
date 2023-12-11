using Core.Models;

namespace Core.Interfaces;

public interface IUsuarioService
{
    Task<UsuarioModel> BuscarUsuarioPeloEmailSenha(string email, string senha);
    Task AlterarSenha(int idUsuario, string novaSenha);
}
