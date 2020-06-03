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
            CharacterPropertiesMapping(builder);
            CharacterPrimaryKeyMapping(builder);
            CharacterTableMapping(builder);
        }

        private void CharacterPropertiesMapping(EntityTypeBuilder<Image> builder)
        {

            builder.Property(x => x.extension)
                .HasMaxLength(400)
                .HasColumnName("Extension");

            builder.Property(x => x.path)
                .HasMaxLength(400)
                .HasColumnName("Path");

        }

        private void CharacterPrimaryKeyMapping(EntityTypeBuilder<Image> builder)
        {
            builder.HasKey(x => x.Id);
        }

        private void CharacterTableMapping(EntityTypeBuilder<Image> builder)
        {
            builder.ToTable("Image");
        }
    }
}
