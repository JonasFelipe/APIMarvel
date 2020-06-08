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
            PropertiesMapping(builder);
            PrimaryKeyMapping(builder);
            TableMapping(builder);
        }

        private void TableMapping(EntityTypeBuilder<Url> builder)
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

        private void PrimaryKeyMapping(EntityTypeBuilder<Url> builder)
        {
            builder.HasKey(con => con.Id);
        }

        private void PropertiesMapping(EntityTypeBuilder<Url> builder)
        {
            builder.ToTable("Url");
        }
    }
}
