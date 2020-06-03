using Marvel.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marvel.Repository.Configuration.Mapping
{
    public class EventMappingConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            CharacterPropertiesMapping(builder);
            CharacterPrimaryKeyMapping(builder);
            CharacterTableMapping(builder);
        }


        private void CharacterPropertiesMapping(EntityTypeBuilder<Event> builder)
        {
            builder.Property(x => x.returned)
                .HasColumnName("Returned");

            builder.Property(x => x.available)
                .HasColumnName("Available");

            builder.Property(x => x.collectionURI)
                .HasMaxLength(200)
                .HasColumnName("CollectionURI");

            builder.HasOne<Character>(con => con.Character)
                .WithMany(con => con.events)
                .HasForeignKey(con => con.CharacterId);
        }

        private void CharacterPrimaryKeyMapping(EntityTypeBuilder<Event> builder)
        {
            builder.HasKey(x => x.Id);
        }

        private void CharacterTableMapping(EntityTypeBuilder<Event> builder)
        {
            builder.ToTable("Event");
        }
    }
}
