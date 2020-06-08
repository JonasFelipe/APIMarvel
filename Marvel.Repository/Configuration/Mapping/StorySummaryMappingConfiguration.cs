using Marvel.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marvel.Repository.Configuration.Mapping
{
    public class StorySummaryMappingConfiguration : IEntityTypeConfiguration<StorySummary>
    {
        public void Configure(EntityTypeBuilder<StorySummary> builder)
        {
            PropertiesMapping(builder);
            PrimaryKeyMapping(builder);
            TableMapping(builder);
        }

        private void PropertiesMapping(EntityTypeBuilder<StorySummary> builder)
        {
            builder.Property(x => x.name)
                .HasMaxLength(200)
                .HasColumnName("Name");

            builder.Property(x => x.resourceURI)
                .HasMaxLength(600)
                .HasColumnName("ResourceURI");

            builder.Property(x => x.type)
                .HasMaxLength(600)
                .HasColumnName("Type");

            builder.HasOne<Story>(x => x.Story)
                .WithMany(x => x.items)
                .HasForeignKey(x => x.StoryId);
        }

        private void PrimaryKeyMapping(EntityTypeBuilder<StorySummary> builder)
        {
            builder.HasKey(x => x.Id);
        }

        private void TableMapping(EntityTypeBuilder<StorySummary> builder)
        {
            builder.ToTable("StorySummary");
        }
    }
}
