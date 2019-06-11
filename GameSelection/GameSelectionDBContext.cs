using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSelection
{
    public class GameSelectionDBContext : DbContext
    {
        public DbSet<GameStatistics> GameStatistics { get; set; }

        public GameSelectionDBContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=GameSelectionStatistics;Trusted_connection=True;");
        }
    }
}
