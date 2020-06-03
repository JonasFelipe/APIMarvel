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
            CharacterPropertiesMapping(builder);
            CharacterPrimaryKeyMapping(builder);
            CharacterTableMapping(builder);
        }

        private void CharacterPropertiesMapping(EntityTypeBuilder<SerieSummary> builder)
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

        private void CharacterPrimaryKeyMapping(EntityTypeBuilder<SerieSummary> builder)
        {
            builder.HasKey(x => x.Id);
        }

        private void CharacterTableMapping(EntityTypeBuilder<SerieSummary> builder)
        {
            builder.ToTable("SerieSummary");
        }
    }
}
