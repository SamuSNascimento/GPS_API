using Infraestrutura.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestrutura.DataBaseContext.Configurations;

internal class EnderecoConfiguration : IEntityTypeConfiguration<EnderecoDTO>
{
    public void Configure(EntityTypeBuilder<EnderecoDTO> builder)
    {
        builder.HasKey(x => x.IdEndereco);
        builder.Property(x => x.CEP);
        builder.Property(x => x.Rua);
        builder.Property(x => x.Bairro);
        builder.Property(x => x.Cidade);
        builder.Property(x => x.Estado);

        builder.HasOne(x => x.Funcionario)
            .WithMany(x => x.Enderecos)
            .HasForeignKey(x => x.IdFuncionario)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
