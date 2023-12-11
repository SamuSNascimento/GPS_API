using Infraestrutura.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestrutura.DataBaseContext.Configurations;

internal class TelefoneConfiguration : IEntityTypeConfiguration<TelefoneDTO>
{
    public void Configure(EntityTypeBuilder<TelefoneDTO> builder)
    {
        builder.HasKey(x => x.IdTelefone);
        builder.Property(x => x.NumeroFixo);
        builder.Property(x => x.NumeroCell);
        builder.Property(x => x.DDD_Telefone);
        builder.Property(x => x.DDD_Celular);

        builder.HasOne(x => x.Funcionario)
            .WithMany(x => x.Telefones)
            .HasForeignKey(x => x.IdFuncionario)
            .OnDelete(DeleteBehavior.Restrict);

    }
}
