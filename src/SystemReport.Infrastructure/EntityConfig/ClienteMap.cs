using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SystemReport.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SystemReport.Infrastructure.EntityConfig
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder
               .HasKey(c => c.ClienteId);

            builder
                .HasMany(c => c.Contatos)
                .WithOne(c => c.Cliente)
                .HasForeignKey(c => c.ClienteId)
                .HasPrincipalKey(c => c.ClienteId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(e => e.Nome)
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder
                .HasOne(x => x.Endereco)
                .WithOne(x => x.Cliente)
                .HasForeignKey<Endereco>(x => x.ClienteId);

            builder
                .Property(e => e.CPF)
                .HasColumnType("varchar(200)")
                .IsRequired();
        }
    }
}
