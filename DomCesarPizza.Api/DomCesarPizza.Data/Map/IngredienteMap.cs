﻿using DomCesarPizza.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomCesarPizza.Data.Map
{
    public class IngredienteMap : IEntityTypeConfiguration<Ingrediente>
    {
       
        public void Configure(EntityTypeBuilder<Ingrediente> builder)
        {
            builder.ToTable("Ingrediente");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(x => x.Descricao)
                 .HasColumnType("varchar(500)");
                           
        }
    }
}


