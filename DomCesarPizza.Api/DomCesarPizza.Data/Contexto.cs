using DomCesarPizza.Data.Map;
using DomCesarPizza.Domain.Modelo;
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=desenv;DataBase=DomCesarPizza;User ID=Sa;Password=Abcd1234");
            base.OnConfiguring(optionsBuilder);
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
