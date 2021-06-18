using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Eleva_WebAPI.Models;

namespace Eleva_WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) { }        
        public DbSet<Escola> Escolas { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            
        }
    }
}