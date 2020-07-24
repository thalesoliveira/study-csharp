using DomCesarPizza.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomCesarPizza.Data.Map
{
    public class AgendaMap : IEntityTypeConfiguration<Agenda>
    {
        public void Configure(EntityTypeBuilder<Agenda> builder)
        {
            builder.ToTable("Agenda");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.DataInicio)
                .HasColumnType("smalldatetime")
                .IsRequired();

            builder.Property(x => x.DataFim)
                .HasColumnType("smalldatetime")
                .IsRequired();
        }
    }
}
