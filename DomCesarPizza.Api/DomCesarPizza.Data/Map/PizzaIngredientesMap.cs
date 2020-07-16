using DomCesarPizza.Domain.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomCesarPizza.Data.Map
{
    //Configuracao N:N
    class PizzaIngredientesMap : IEntityTypeConfiguration<PizzaIngredientes>
    {
        public void Configure(EntityTypeBuilder<PizzaIngredientes> builder)
        {
            builder.ToTable("PizzaIngredientes");

            builder.HasKey(t => new { t.IdIngrediente, t.IdPizza});
                       
            builder.HasOne(i => i.Ingrediente)
                 .WithMany(pi => pi.PizzaIngredientes)
                 .HasForeignKey(i => i.IdIngrediente);

            builder.HasOne(p => p.Pizza)
                 .WithMany(pi => pi.PizzaIngredientes)
                 .HasForeignKey(p => p.IdPizza);

            builder.Property(x => x.Id)
                .UseIdentityColumn();
        }
    }
}
