using Marvel.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marvel.Repository.Configuration.Mapping
{
    public class UrlMappingConfiguration : IEntityTypeConfiguration<Url>
    {
        public void Configure(EntityTypeBuilder<Url> builder)
        {
            CharacterPropertiesMapping(builder);
            CharacterPrimaryKeyMapping(builder);
            CharacterTableMapping(builder);
        }

        private void CharacterTableMapping(EntityTypeBuilder<Url> builder)
        {
            builder.Property(con => con.type)
                .HasColumnName("Type")
                .HasMaxLength(200);

            builder.Property(con => con.url)
                .HasColumnName("Url")
                .HasMaxLength(200);

            builder.HasOne<Character>(con => con.Character)
                .WithMany(con => con.urls)
                .HasForeignKey(con => con.CharacterId);
        }

        private void CharacterPrimaryKeyMapping(EntityTypeBuilder<Url> builder)
        {
            builder.HasKey(con => con.Id);
        }

        private void CharacterPropertiesMapping(EntityTypeBuilder<Url> builder)
        {
            builder.ToTable("Url");
        }
    }
}
