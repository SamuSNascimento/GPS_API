using Infraestrutura.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestrutura.DataBaseContext.Configurations;

internal class FeriasConfiguration : IEntityTypeConfiguration<FeriasDTO>
{
    public void Configure(EntityTypeBuilder<FeriasDTO> builder)
    {
        builder.HasKey(x => x.IdFerias);
        builder.Property(x => x.DataInicio);
        builder.Property(x => x.DataFim);
        builder.Property(x => x.TipoFerias);
        builder.Property(x => x.Status);

        builder.HasOne(x => x.Funcionario)
            .WithMany(x => x.Ferias)
            .HasForeignKey(x => x.IdFuncionario)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
