using Infraestrutura.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestrutura.DataBaseContext.Configurations;

internal class FolhaPagamentoConfiguration : IEntityTypeConfiguration<FolhaPagamentoDTO>
{
    public void Configure(EntityTypeBuilder<FolhaPagamentoDTO> builder)
    {
        builder.HasKey(x => x.IdFolhaPagemento);
        builder.Property(x => x.SalarioBase);
        builder.Property(x => x.Beneficios);
        builder.Property(x => x.HorasExtras);
        builder.Property(x => x.Adicionais);
        builder.Property(x => x.Deducoes);
        builder.Property(x => x.Impostos);
        builder.Property(x => x.ContribuicoesPrevidenciarias);
        builder.Property(x => x.DataFolhaPagamento);

        builder.HasOne(x => x.Funcionario)
            .WithMany(x => x.FolhasPagamentos)
            .HasForeignKey(x => x.IdFuncionario)
            .OnDelete(DeleteBehavior.Restrict);

    }
}
