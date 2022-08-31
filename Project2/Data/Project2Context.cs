using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project2.Models;

namespace Project2.Data
{
    public class Project2Context : DbContext
    {
        public Project2Context (DbContextOptions<Project2Context> options)
            : base(options)
        {
        }

        public DbSet<Project2.Models.Hero> Hero { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Hero>().HasData(new Models.Hero() { Id = 1, Name = "Hero 1" });
            modelBuilder.Entity<Hero>().HasData(new Models.Hero() { Id = 2, Name = "Hero 2" });
            modelBuilder.Entity<Hero>().HasData(new Models.Hero() { Id = 3, Name = "Hero 3" });
            modelBuilder.Entity<Hero>().HasData(new Models.Hero() { Id = 4, Name = "Hero 4" });
            modelBuilder.Entity<Hero>().HasData(new Models.Hero() { Id = 5, Name = "Hero 5" });
        }
    }
}
