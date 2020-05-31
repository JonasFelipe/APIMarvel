using Marvel.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Marvel.Repository.Context
{
    public class MarvelContext : DbContext 
    {
        public MarvelContext(DbContextOptions<MarvelContext> options)
            : base(options)
        {
            
        }
        
        public DbSet<Character> Character { get; set; }
        public DbSet<Comic> Comic { get; set; }
        public DbSet<ComicSummary> CommicSummary { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<EventSummary> EventSummmary { get; set; }
        public DbSet<Image> Image { get; set; }
        public DbSet<Serie> Serie { get; set; }
        public DbSet<SerieSummary> SerieSummary { get; set; }
        public DbSet<Story> Story { get; set; }
        public DbSet<StorySummary> StorySummary { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .ApplyConfiguration(new CharacterMappingConfiguration());

            modelBuilder
                .ApplyConfiguration(new CharacterMappingConfiguration());

            modelBuilder
                .ApplyConfiguration(new CharacterMappingConfiguration());

            modelBuilder
                .ApplyConfiguration(new CharacterMappingConfiguration());

            modelBuilder
                .ApplyConfiguration(new CharacterMappingConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
