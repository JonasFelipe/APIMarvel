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
            PropertiesMapping(builder);
            PrimaryKeyMapping(builder);
            TableMapping(builder);
        }


        private void PropertiesMapping(EntityTypeBuilder<Event> builder)
        {
            builder.Property(x => x.available)
                .HasColumnName("Available");

            builder.Property(x => x.collectionURI)
                .HasMaxLength(200)
                .HasColumnName("CollectionURI");

        }

        private void PrimaryKeyMapping(EntityTypeBuilder<Event> builder)
        {
            builder.HasKey(x => x.Id);
        }

        private void TableMapping(EntityTypeBuilder<Event> builder)
        {
            builder.ToTable("Event");
        }
    }
}
