using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SystemReport.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SystemReport.Infrastructure.EntityConfig
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder
                .Property(e => e.Logradouro)
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder
                .Property(e => e.Bairro)
                .HasColumnType("varchar(200)")
                .IsRequired();
        }
    }
}
