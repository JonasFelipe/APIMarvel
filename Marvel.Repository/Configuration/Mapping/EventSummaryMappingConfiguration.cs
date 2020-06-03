using Marvel.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marvel.Repository.Configuration.Mapping
{
    public class EventSummaryMappingConfiguration : IEntityTypeConfiguration<EventSummary>
    {
        public void Configure(EntityTypeBuilder<EventSummary> builder)
        {
            CharacterPropertiesMapping(builder);
            CharacterPrimaryKeyMapping(builder);
            CharacterTableMapping(builder);
        }

        private void CharacterPropertiesMapping(EntityTypeBuilder<EventSummary> builder)
        {
            builder.Property(x => x.name)
                .HasMaxLength(200)
                .HasColumnName("Name");

            builder.Property(x => x.resourceURI)
                .HasMaxLength(600)
                .HasColumnName("ResourceURI");

            builder.HasOne<Event>(x => x.Event)
                .WithMany(x => x.items)
                .HasForeignKey(x => x.EventId);
        }

        private void CharacterPrimaryKeyMapping(EntityTypeBuilder<EventSummary> builder)
        {
            builder.HasKey(x => x.Id);
        }

        private void CharacterTableMapping(EntityTypeBuilder<EventSummary> builder)
        {
            builder.ToTable("EventSummary");
        }
    }
}
