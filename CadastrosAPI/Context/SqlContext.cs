using CadastrosAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastrosAPI.Context
{
    public class SqlContext : DbContext
    {
        public SqlContext() {}

        public SqlContext(DbContextOptions<SqlContext> options)
                : base(options)
        {}

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Servico> Servicos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Produto>(p =>
            {
                p.HasKey(pk => new { pk.IdProduto });
            });

            modelBuilder.Entity<Cliente>(c =>
            {
                c.HasKey(pk => new { pk.IdCliente }).HasName("PK_Clientes");
            });

            modelBuilder.Entity<Servico>(s =>
            {
                s.HasKey(pk => new { pk.IdServico }).HasName("PK_Servicos");
            });
        }
    }
}
