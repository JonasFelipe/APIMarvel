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
            CharacterPropertiesMapping(builder);
            CharacterPrimaryKeyMapping(builder);
            CharacterTableMapping(builder);
        }

        private void CharacterTableMapping(EntityTypeBuilder<Character> builder)
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
                .HasForeignKey<Image>(x => x.CurrentCharacterId);

        }

        private void CharacterPrimaryKeyMapping(EntityTypeBuilder<Character> builder)
        {
            builder.HasKey(u => u.Id);
        }

        private void CharacterPropertiesMapping(EntityTypeBuilder<Character> builder)
        {
            builder.ToTable("Character");
        }
    }

} 

