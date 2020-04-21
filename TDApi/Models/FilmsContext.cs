using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TDApi.Models.Auth;

namespace TDApi.Models
{
    public class FilmsContext : DbContext
    {
        public FilmsContext(DbContextOptions<FilmsContext> options = null)
      : base(options)
        {
        }
        //Les entités gérées par le DbContext
        public DbSet<User> Users { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Genre> Genres { get; set; }

        //la configuration à la base de données Sqlite locale
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlite($"Data Source={AppContext.BaseDirectory}/films.db");
            }
        }
        //ou la configuration à la base de données MySql
        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //    => options.UseMySql("server=localhost;port=3306;userid=root;password=;database=films;");

        //Les relations entre les entités


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Film>(entity =>
            {
                entity.HasOne(d => d.Genre).WithMany(p => p.Films);
            });
        }
    }
}
