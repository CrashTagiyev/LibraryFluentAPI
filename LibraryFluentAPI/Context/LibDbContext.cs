using LibraryFluentAPI.Configurations;
using LibraryFluentAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace ConsoleApp1.Contex
{
    public class LibDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-HFMQLBA\\MSSQLSERVER01;Initial Catalog=LibraryFluentAPI;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
            base.OnConfiguring(optionsBuilder);


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        
        }
        public DbSet<Authors> Authors { get; set; }
        public DbSet<Books> Books { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Departments> Departments { get; set; }
        public DbSet<Faculties> Faculties { get; set; }
        public DbSet<Groups> Groups { get; set; }
        public DbSet<Libs> Libs { get; set; }
        public DbSet<Press> Presses { get; set; }
        public DbSet<SCards> SCards { get; set; }
        public DbSet<Students> Students { get; set; }
        public DbSet<TCards> TCards { get; set; }
        public DbSet<Teachers> Teachers { get; set; }
        public DbSet<Themes> Themes { get; set; }



    }
}
