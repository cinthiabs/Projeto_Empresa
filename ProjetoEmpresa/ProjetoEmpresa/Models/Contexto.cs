using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEmpresa.Models
{
    public class Contexto:DbContext
    {
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fornecedor>()
                .HasOne(e => e.Empresa)
                .WithMany(e => e.Fornecedores)
                .HasForeignKey(e => e.empresaId);

            modelBuilder.Entity<Empresa>()
               .HasMany(e => e.Fornecedores)
               .WithOne(e => e.Empresa);

        }
    }
}
