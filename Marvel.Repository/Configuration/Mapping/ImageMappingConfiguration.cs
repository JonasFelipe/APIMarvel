using Marvel.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marvel.Repository.Configuration.Mapping
{
    public class ImageMappingConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            PropertiesMapping(builder);
            PrimaryKeyMapping(builder);
            TableMapping(builder);
        }

        private void PropertiesMapping(EntityTypeBuilder<Image> builder)
        {

            builder.Property(x => x.extension)
                .HasMaxLength(400)
                .HasColumnName("Extension");

            builder.Property(x => x.path)
                .HasMaxLength(400)
                .HasColumnName("Path");

        }

        private void PrimaryKeyMapping(EntityTypeBuilder<Image> builder)
        {
            builder.HasKey(x => x.Id);
        }

        private void TableMapping(EntityTypeBuilder<Image> builder)
        {
            builder.ToTable("Image");
        }
    }
}
