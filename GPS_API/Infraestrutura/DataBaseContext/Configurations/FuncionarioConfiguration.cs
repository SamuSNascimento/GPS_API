using Infraestrutura.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestrutura.DataBaseContext.Configurations;

internal class FuncionarioConfiguration : IEntityTypeConfiguration<FuncionarioDTO>
{
    public void Configure(EntityTypeBuilder<FuncionarioDTO> builder)
    {
        builder.HasKey(x => x.IdFuncionario);
        builder.Property(x => x.NomeFuncionario);
        builder.HasIndex(x => x.CPF).IsUnique();
        builder.Property(x => x.RG);
        builder.Property(x => x.Cargo);
        builder.Property(x => x.SalarioBase);
        builder.Property(x => x.ContaBancaria);
    }
}
