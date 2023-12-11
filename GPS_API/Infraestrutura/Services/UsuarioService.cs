using Core.Interfaces;
using Core.Models;

namespace Infraestrutura.Services;

public class UsuarioService : IUsuarioService
{

    private readonly IUsuarioRepositorySQL _usuarioRepositorySQL;

    public UsuarioService(IUsuarioRepositorySQL usuarioRepositorySQL)
    {
        _usuarioRepositorySQL = usuarioRepositorySQL;
    }

    public async Task AlterarSenha(int idUsuario, string novaSenha)
    {
        try
        {
            await _usuarioRepositorySQL.AlterarSenha(idUsuario, novaSenha);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<UsuarioModel> BuscarUsuarioPeloEmailSenha(string email, string senha)
    {
        try
        {
            return await _usuarioRepositorySQL.BuscarUsuarioPeloEmailSenha(email, senha);
        }
        catch (Exception)
        {
            throw;
        }
    }
}
