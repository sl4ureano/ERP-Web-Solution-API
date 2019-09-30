using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SystemReport.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SystemReport.Infrastructure.EntityConfig
{
    public class ProfissaoMap : IEntityTypeConfiguration<Profissao>
    {
        public void Configure(EntityTypeBuilder<Profissao> builder)
        {
            builder
                .Property(e => e.Nome)
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder
                .Property(e => e.Descricao)
                .HasColumnType("varchar(1000)")
                .IsRequired();
        }
    }
}
