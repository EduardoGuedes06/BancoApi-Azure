using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Business.Models;

namespace Data.Mappings
{
    public class ContaJuridicaMapping : IEntityTypeConfiguration<ContaJuridica>
    {
        public void Configure(EntityTypeBuilder<ContaJuridica> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.CNPJ)
                .IsRequired()
                .HasColumnType("varchar(14)");

            builder.Property(p => p.ChaveJ)
                .IsRequired()
                .HasColumnType("varchar(6)");

            builder.Property(p => p.Usuario)
                .IsRequired()
                .HasColumnType("varchar(35)");

            builder.Property(p => p.Senha8Dig)
                .IsRequired()
                .HasColumnType("varchar(8)");

            builder.Property(p => p.Senha6Dig)
                .IsRequired()
                .HasColumnType("varchar(6)");

            builder.Property(p => p.DataCriacao)
                .IsRequired()
                .HasColumnType("Datetime");

            builder.Property(p => p.UsuarioLogin)
                .IsRequired()
                .HasColumnType("varchar(35)");

            builder.ToTable("ContaJuridica");
        }
    }
}