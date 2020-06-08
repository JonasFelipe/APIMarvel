using Marvel.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marvel.Repository.Configuration.Mapping
{
    public class SerieSummaryMappingConfiguration : IEntityTypeConfiguration<SerieSummary>
    {
        public void Configure(EntityTypeBuilder<SerieSummary> builder)
        {
            PropertiesMapping(builder);
            PrimaryKeyMapping(builder);
            TableMapping(builder);
        }

        private void PropertiesMapping(EntityTypeBuilder<SerieSummary> builder)
        {
            builder.Property(x => x.name)
                .HasMaxLength(200)
                .HasColumnName("Name");

            builder.Property(x => x.resourceURI)
                .HasMaxLength(600)
                .HasColumnName("ResourceURI");

            builder.HasOne<Serie>(x => x.Serie)
                .WithMany(x => x.items)
                .HasForeignKey(x => x.SerieId);
        }

        private void PrimaryKeyMapping(EntityTypeBuilder<SerieSummary> builder)
        {
            builder.HasKey(x => x.Id);
        }

        private void TableMapping(EntityTypeBuilder<SerieSummary> builder)
        {
            builder.ToTable("SerieSummary");
        }
    }
}
