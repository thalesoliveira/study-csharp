using DomCesarPizza.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomCesarPizza.Data.Map
{
    public class PizzaMap : IEntityTypeConfiguration<Pizza>
    {
        public void Configure(EntityTypeBuilder<Pizza> builder)
        {
            builder.ToTable("Pizza");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(x => x.Descricao)
                 .HasColumnType("varchar(500)")
                  .IsRequired();

            builder.Property(x => x.Preco)
                 .HasColumnType("decimal(18,2)")
                  .IsRequired();
        }
    }
}
