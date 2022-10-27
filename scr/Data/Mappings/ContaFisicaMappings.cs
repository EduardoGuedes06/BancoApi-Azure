using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Business.Models;

namespace Data.Mappings
{
    public class ContaFisicaMapping : IEntityTypeConfiguration<ContaFisica>
    {
        public void Configure(EntityTypeBuilder<ContaFisica> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.CPF)
                .IsRequired()
                .HasColumnType("varchar(11)");

            builder.Property(p => p.Agencia)
                .IsRequired()
                .HasColumnType("varchar(5)");

            builder.Property(p => p.ContaCorrente)
                .IsRequired()
                .HasColumnType("varchar(10)");

            builder.Property(p => p.Senha8dig)
                .IsRequired()
                .HasColumnType("varchar(8)");

            builder.Property(p => p.Senha6dig)
                .IsRequired()
                .HasColumnType("varchar(6)");

            builder.Property(p => p.DataCriacao)
                .IsRequired()
                .HasColumnType("Datetime");

            builder.Property(p => p.UsuarioLogin)
                .IsRequired()
                .HasColumnType("varchar(35)");

            builder.ToTable("ContaFisica");
        }
    }
}