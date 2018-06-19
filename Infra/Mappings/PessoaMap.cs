using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Mappings
{
    public class PessoaMap : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.Property(p => p.Id).HasColumnName("ID").ValueGeneratedOnAdd();
            builder.Property(p => p.Nome).HasMaxLength(255).HasColumnName("NOME").IsRequired(true);
            builder.Property(p => p.DataNascimento).HasColumnName("DATA_NASCIMENTO").IsRequired(false);
            builder.Property(p => p.Email).HasColumnName("EMAIL").HasMaxLength(255);
            builder.Property(p => p.Senha).HasColumnName("SENHA").IsRequired(true);
            builder.ToTable("pessoa");
        }
    }
}
