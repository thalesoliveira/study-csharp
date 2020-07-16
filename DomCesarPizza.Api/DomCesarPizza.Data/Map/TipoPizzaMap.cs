using DomCesarPizza.Domain.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomCesarPizza.Data.Map
{
    public class TipoPizzaMap : IEntityTypeConfiguration<TipoPizza>
    {
        public void Configure(EntityTypeBuilder<TipoPizza> builder)
        {
            builder.ToTable("TipoPizza");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(x => x.Descricao)
                 .HasColumnType("varchar(500)");

            //Configuracao 1:N
            builder.HasMany<Pizza>(p => p.Pizzas)
                 .WithOne(t => t.TipoPizza)
                 .HasForeignKey(t => t.IdTipoPizza);
        }
    }
}
