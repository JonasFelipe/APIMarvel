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
            CharacterPropertiesMapping(builder);
            CharacterPrimaryKeyMapping(builder);
            CharacterTableMapping(builder);
        }


        private void CharacterPropertiesMapping(EntityTypeBuilder<Serie> builder)
        {
            builder.Property(x => x.returned)
                .HasColumnName("Returned");

            builder.Property(x => x.available)
                .HasColumnName("Available");

            builder.Property(x => x.collectionURI)
                .HasMaxLength(200)
                .HasColumnName("CollectionURI");

            builder.HasOne<Character>(con => con.Character)
                .WithMany(con => con.series)
                .HasForeignKey(con => con.CharacterId);
        }

        private void CharacterPrimaryKeyMapping(EntityTypeBuilder<Serie> builder)
        {
            builder.HasKey(x => x.Id);
        }

        private void CharacterTableMapping(EntityTypeBuilder<Serie> builder)
        {
            builder.ToTable("Serie");
        }
    }
}
