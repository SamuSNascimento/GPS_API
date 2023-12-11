using Infraestrutura.DataBaseContext.Configurations;
using Infraestrutura.DTOs;
using Microsoft.EntityFrameworkCore;

namespace Infraestrutura.DataBaseContext;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new FuncionarioConfiguration());
        modelBuilder.ApplyConfiguration(new EnderecoConfiguration());
        modelBuilder.ApplyConfiguration(new TelefoneConfiguration());
        modelBuilder.ApplyConfiguration(new FolhaPagamentoConfiguration());
        modelBuilder.ApplyConfiguration(new RegistroPontoConfiguration());
        modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
        modelBuilder.ApplyConfiguration(new FeriasConfiguration());
    }

    public DbSet<FuncionarioDTO> Funcionario { get; set; }
    public DbSet<EnderecoDTO> Endereco { get; set; }
    public DbSet<TelefoneDTO> Telefone { get; set; }
    public DbSet<FeriasDTO> Ferias { get; set; }
    public DbSet<FolhaPagamentoDTO> FolhaPagamento { get; set; }
    public DbSet<RegistroPontoDTO> RegistroPonto { get; set; }
    public DbSet<UsuarioDTO> Usuario { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=GPS_HOMOLOGACAO;User Id=sa;Password=MLAEnerwatt123..;TrustServerCertificate=True");
    }

}
