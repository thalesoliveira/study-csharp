using DomCesarPizza.Data.Map;
using DomCesarPizza.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace DomCesarPizza.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Agenda> DiaCardapio { get; set; }
        public DbSet<Cardapio> Cardapio { get; set; }
        public DbSet<Ingrediente> Ingrediente { get; set; }
        public DbSet<Pizza> Pizza { get; set; }
        public DbSet<TipoPizza> TipoPizza { get; set; }
        public DbSet<PizzaIngredientes> PizzaIngredientes { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AgendaMap());
            modelBuilder.ApplyConfiguration(new CardapioMap());
            modelBuilder.ApplyConfiguration(new AgendaCardapioMap());
            modelBuilder.ApplyConfiguration(new IngredienteMap());
            modelBuilder.ApplyConfiguration(new PizzaMap());
            modelBuilder.ApplyConfiguration(new PizzaIngredientesMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
