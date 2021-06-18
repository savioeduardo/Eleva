using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Eleva_WebAPI.Models;

namespace Eleva_WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) { }        
        public DbSet<Escola> Escolas { get; set; }
        public DbSet<Turma> Turmas { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
             builder.Entity<Escola>()
                .HasData(new List<Escola>(){
                    new Escola(1, "Coleguium - Alípio de Melo", "R. dos Agrônomos, 185", "Belo Horizonte", "MG", "(31) 3024-9540"),
                    new Escola(2, "Coleguium - Belvedere Internacional", "Av. Celso Porfírio Machado, 1650", "Belo Horizonte", "MG", "(31) 3568-3807")
                });

                builder.Entity<Turma>()
                .HasData(new List<Turma>(){
                    new Turma(1, "1A-1", 1),
                    new Turma(2, "1A-2", 1),
                    new Turma(3, "1A-3", 1),
                    new Turma(4, "1B-1", 1),
                    new Turma(5, "1B-2", 1),
                    new Turma(6, "1A-1", 2),
                    new Turma(7, "1A-2", 2),
                    new Turma(8, "1A-3", 2),
                    new Turma(9, "1B-1", 2),
                    new Turma(10, "1B-2", 2)
                });
        }
    }
}