using Core.Interfaces;
using Core.Models;
using Infraestrutura.DataBaseContext;
using Microsoft.EntityFrameworkCore;

namespace Infraestrutura.Repositories;

public class UsuarioReporsitorySQL : IUsuarioRepositorySQL
{
    private readonly ApplicationDbContext _dbContext;
    public UsuarioReporsitorySQL(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AlterarSenha(int idUsuario, string novaSenha)
    {
        try
        {

            var usuario = await _dbContext.Usuario.Where(x => x.IdUsuario == idUsuario).FirstOrDefaultAsync();
            usuario.Password = novaSenha;

            _dbContext.Usuario.Update(usuario);
            _dbContext.SaveChanges();

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
            var usuario = await _dbContext.Usuario
                .Include(x => x.Funcionario)
                .Where(x => x.Email == email && x.Password == senha)
                .FirstOrDefaultAsync();

            UsuarioModel usuarioModel = new();
            usuarioModel = usuario.ConverterDTOParaModel(usuario);

            return usuarioModel;
        }

        catch (Exception)
        {
            throw;
        }
    }
}
