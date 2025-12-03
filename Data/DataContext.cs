using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using OmniMarket.Models;


namespace OmniMarket.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options)
        {
            
        }        

        public DbSet<Produtos> Produto {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produtos>().ToTable("TBL_PRODUTOS");
            modelBuilder.Entity<Produtos>().HasKey(e => e.idProduto);
            modelBuilder.Entity<Produtos>().HasData(new Produtos() {idProduto = 1, idUsuarioVendedor = 1, txtNome = "Icaro", idCategoria =1, vlProduto = 200, qtdEstoque = 3, txtDescricao = "Produto n", stAtivo = true});

        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveColumnType("varchar").HaveMaxLength(200);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        }
    }
}