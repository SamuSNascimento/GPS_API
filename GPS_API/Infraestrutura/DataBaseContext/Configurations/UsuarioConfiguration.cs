using Infraestrutura.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestrutura.DataBaseContext.Configurations;

internal class UsuarioConfiguration : IEntityTypeConfiguration<UsuarioDTO>
{
    public void Configure(EntityTypeBuilder<UsuarioDTO> builder)
    {
        builder.HasKey(x => x.IdUsuario);
        builder.HasIndex(x => x.UserName).IsUnique();
        builder.HasIndex(x => x.Email).IsUnique();
        builder.Property(x => x.Password);
        builder.Property(x => x.NivelDeAcesso);

        builder.HasOne(x => x.Funcionario)
            .WithOne(x => x.Usuario)
            .HasForeignKey<UsuarioDTO>(x => x.IdFuncionario);
    }
}
