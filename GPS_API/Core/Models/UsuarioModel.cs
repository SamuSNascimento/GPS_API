namespace Core.Models;

public class UsuarioModel
{
    public UsuarioModel(int idUsuario, string userName, string email, string password, int nivelDeAcesso)
    {
        IdUsuario = idUsuario;
        UserName = userName;
        Email = email;
        Password = password;
        NivelDeAcesso = nivelDeAcesso;
    }

    public UsuarioModel()
    {

    }

    public int IdUsuario { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public FuncionarioModel? Funcionario { get; set; }
    public int NivelDeAcesso { get; set; }
}
