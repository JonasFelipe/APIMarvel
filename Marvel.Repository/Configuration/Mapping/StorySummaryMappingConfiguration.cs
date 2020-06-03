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
            CharacterPropertiesMapping(builder);
            CharacterPrimaryKeyMapping(builder);
            CharacterTableMapping(builder);
        }

        private void CharacterPropertiesMapping(EntityTypeBuilder<StorySummary> builder)
        {
            builder.Property(x => x.name)
                .HasMaxLength(200)
                .HasColumnName("Name");

            builder.Property(x => x.resourceURI)
                .HasMaxLength(600)
                .HasColumnName("ResourceURI");

            builder.HasOne<Story>(x => x.Story)
                .WithMany(x => x.items)
                .HasForeignKey(x => x.StoryId);
        }

        private void CharacterPrimaryKeyMapping(EntityTypeBuilder<StorySummary> builder)
        {
            builder.HasKey(x => x.Id);
        }

        private void CharacterTableMapping(EntityTypeBuilder<StorySummary> builder)
        {
            builder.ToTable("StorySummary");
        }
    }
}
