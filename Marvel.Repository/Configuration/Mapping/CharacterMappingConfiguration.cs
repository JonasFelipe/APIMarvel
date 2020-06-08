using Marvel.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marvel.Repository.Configuration.Mapping
{
    public class CharacterMappingConfiguration : IEntityTypeConfiguration<Character>
    {         
    
        public void Configure(EntityTypeBuilder<Character> builder)
        {
            PropertiesMapping(builder);
            PrimaryKeyMapping(builder);
            TableMapping(builder);
        }

        private void TableMapping(EntityTypeBuilder<Character> builder)
        {

            builder.Property(con => con.name)
                .HasColumnName("Name")
                .HasMaxLength(100);

            builder.Property(con => con.description)
                .HasColumnName("Description")
                .HasMaxLength(2000);

            builder.Property(con => con.modified)
                .HasColumnName("Modified")
                .HasMaxLength(100);

            builder.Property(con => con.resourceURI)
                .HasColumnName("ResourceURI")
                .HasMaxLength(100);

            builder.HasOne<Image>(x => x.thumbnail)
                .WithOne(x => x.Character)
                .HasForeignKey<Image>(x => x.CharacterId);

            builder.HasOne<Comic>(x => x.comics)
                .WithOne(x => x.Character)
                .HasForeignKey<Comic>(x => x.CharacterId);

            builder.HasOne<Event>(x => x.events)
                .WithOne(x => x.Character)
                .HasForeignKey<Event>(x => x.CharacterId);

            builder.HasOne<Story>(x => x.stories)
                .WithOne(x => x.Character)
                .HasForeignKey<Story>(x => x.CharacterId);

            builder.HasOne<Serie>(x => x.series)
                .WithOne(x => x.Character)
                .HasForeignKey<Serie>(x => x.CharacterId);

        }

        private void PrimaryKeyMapping(EntityTypeBuilder<Character> builder)
        {
            builder.HasKey(u => u.Id);
        }

        private void PropertiesMapping(EntityTypeBuilder<Character> builder)
        {
            builder.ToTable("Character");
        }
    }

} 

