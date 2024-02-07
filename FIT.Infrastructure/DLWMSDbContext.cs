using FIT.Data;
using FIT.Data.IB210156;
using Microsoft.EntityFrameworkCore;

using System.Configuration;

namespace FIT.Infrastructure
{
    public class DLWMSDbContext : DbContext
    {
        private readonly string dbPutanja;

        public DLWMSDbContext()
        {
            dbPutanja = ConfigurationManager.
                ConnectionStrings["DLWMSBaza"].ConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(dbPutanja);
        }
    
        public DbSet<Student> Studenti { get; set; }
        public DbSet<DrzaveIB210156>DrzaveIB210156 { get; set; }
        public DbSet<GradoviIB210156>GradoviIB210156 { get;set; }
        public DbSet<PolozeniPredmetiIB210156> PolozeniPredmeti { get; set; }  

    }
}