using System.Collections.Generic;
using ConversorCriptomonedas.Models;
using Microsoft.EntityFrameworkCore;

namespace ConversorCriptomonedas.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Conversion> Conversions { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
    
}
