using Infraestrutura.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestrutura.DataBaseContext.Configurations;

internal class RegistroPontoConfiguration : IEntityTypeConfiguration<RegistroPontoDTO>
{
    public void Configure(EntityTypeBuilder<RegistroPontoDTO> builder)
    {
        builder.HasKey(x => x.IdRegistroPonto);
        builder.Property(x => x.DataHoraEntrada);
        builder.Property(x => x.DataHoraSaida);
        builder.Property(x => x.HorasExtras);
        builder.Property(x => x.Faltas);
        builder.Property(x => x.Atrasos);

        builder.HasOne(x => x.Funcionario)
            .WithMany(x => x.RegistroPonto)
            .HasForeignKey(x => x.IdFuncionario)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.FolhaPagamento)
            .WithMany(x => x.RegistroPonto)
            .HasForeignKey(x => x.IdFolhaDePagamento)
            .OnDelete(DeleteBehavior.Restrict);

    }
}
