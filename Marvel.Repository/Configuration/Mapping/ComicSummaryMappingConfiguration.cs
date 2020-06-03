using Marvel.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Marvel.Repository.Configuration.Mapping
{
    public class ComicSummaryMappingConfiguration : IEntityTypeConfiguration<ComicSummary>
    {
        public void Configure(EntityTypeBuilder<ComicSummary> builder)
        {
            CharacterPropertiesMapping(builder);
            CharacterPrimaryKeyMapping(builder);
            CharacterTableMapping(builder);
        }

        private void CharacterPropertiesMapping(EntityTypeBuilder<ComicSummary> builder)
        {
            builder.Property(x => x.name)
                .HasMaxLength(200)
                .HasColumnName("Name");

            builder.Property(x => x.resourceURI)
                .HasMaxLength(600)
                .HasColumnName("ResourceURI");

            builder.HasOne<Comic>(x => x.Comic)
                .WithMany(x => x.items)
                .HasForeignKey(x => x.ComicId);
        }

        private void CharacterPrimaryKeyMapping(EntityTypeBuilder<ComicSummary> builder)
        {
            builder.HasKey(x => x.Id);
        }

        private void CharacterTableMapping(EntityTypeBuilder<ComicSummary> builder)
        {
            builder.ToTable("ComicSummary");
        }
    }
}
