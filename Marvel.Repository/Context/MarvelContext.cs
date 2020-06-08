using Marvel.Domain.Entities;
using Marvel.Repository.Configuration.Mapping;
using Microsoft.EntityFrameworkCore;


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
        public DbSet<Url> Url { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .ApplyConfiguration(new CharacterMappingConfiguration());

            modelBuilder
                .ApplyConfiguration(new ComicMappingConfiguration());

            modelBuilder
                .ApplyConfiguration(new ComicSummaryMappingConfiguration());

            modelBuilder
                .ApplyConfiguration(new EventMappingConfiguration());

            modelBuilder
                .ApplyConfiguration(new EventSummaryMappingConfiguration());

            modelBuilder
                .ApplyConfiguration(new ImageMappingConfiguration());

            modelBuilder
                .ApplyConfiguration(new SerieMappingConfiguration());

            modelBuilder
                .ApplyConfiguration(new SerieSummaryMappingConfiguration());

            modelBuilder
                .ApplyConfiguration(new StoryMappingConfiguration());

            modelBuilder
                .ApplyConfiguration(new StorySummaryMappingConfiguration());

            modelBuilder
                .ApplyConfiguration(new UrlMappingConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
