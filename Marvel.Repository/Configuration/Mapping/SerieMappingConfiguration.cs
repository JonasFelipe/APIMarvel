using Marvel.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marvel.Repository.Configuration.Mapping
{
    public class SerieMappingConfiguration : IEntityTypeConfiguration<Serie>
    {
        public void Configure(EntityTypeBuilder<Serie> builder)
        {
            PropertiesMapping(builder);
            PrimaryKeyMapping(builder);
            TableMapping(builder);
        }


        private void PropertiesMapping(EntityTypeBuilder<Serie> builder)
        {
            builder.Property(x => x.available)
                .HasColumnName("Available");

            builder.Property(x => x.collectionURI)
                .HasMaxLength(200)
                .HasColumnName("CollectionURI");

        }

        private void PrimaryKeyMapping(EntityTypeBuilder<Serie> builder)
        {
            builder.HasKey(x => x.Id);
        }

        private void TableMapping(EntityTypeBuilder<Serie> builder)
        {
            builder.ToTable("Serie");
        }
    }
}
