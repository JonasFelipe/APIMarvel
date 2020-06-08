using Marvel.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marvel.Repository.Configuration.Mapping
{
    public class ComicMappingConfiguration : IEntityTypeConfiguration<Comic>
    {
        public void Configure(EntityTypeBuilder<Comic> builder)
        {
            PropertiesMapping(builder);
            PrimaryKeyMapping(builder);
            TableMapping(builder);
        }

        private void TableMapping(EntityTypeBuilder<Comic> builder)
        {
            builder.Property(x => x.available)
                .HasColumnName("Available");

            builder.Property(x => x.collectionURI)
                .HasMaxLength(200)
                .HasColumnName("CollectionURI");
        }

        private void PrimaryKeyMapping(EntityTypeBuilder<Comic> builder)
        {
            builder.HasKey(x => x.Id);
        }

        private void PropertiesMapping(EntityTypeBuilder<Comic> builder)
        {
            builder.ToTable("Comic");
        }
    }
}
