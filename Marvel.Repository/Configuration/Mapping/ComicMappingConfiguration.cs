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
            CharacterPropertiesMapping(builder);
            CharacterPrimaryKeyMapping(builder);
            CharacterTableMapping(builder);
        }

        private void CharacterTableMapping(EntityTypeBuilder<Comic> builder)
        {
            builder.Property(x => x.returned)
                .HasColumnName("Returned");

            builder.Property(x => x.available)
                .HasColumnName("Available");

            builder.Property(x => x.collectionURI)
                .HasMaxLength(200)
                .HasColumnName("CollectionURI");

            builder.HasOne<Character>(con => con.Character)
                .WithMany(con => con.comics)
                .HasForeignKey(con => con.CharacterId);
        }

        private void CharacterPrimaryKeyMapping(EntityTypeBuilder<Comic> builder)
        {
            builder.HasKey(x => x.Id);
        }

        private void CharacterPropertiesMapping(EntityTypeBuilder<Comic> builder)
        {
            builder.ToTable("Comic");
        }
    }
}
