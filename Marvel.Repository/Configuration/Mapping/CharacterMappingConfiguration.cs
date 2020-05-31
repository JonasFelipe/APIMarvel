using Marvel.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marvel.Repository.Configuration.Mapping
{
    public class CharacterMappingConfiguration
    {         
    
        public void Configure(EntityTypeBuilder<Character> builder)
        {
            CharacterPropertiesMapping(builder);
            CharacterPrimaryKeyMapping(builder);
            CharacterTableMapping(builder);
        }

        private void CharacterTableMapping(EntityTypeBuilder<Character> builder)
        {
            throw new NotImplementedException();
        }

        private void CharacterPrimaryKeyMapping(EntityTypeBuilder<Character> builder)
        {
            
        }

        private void CharacterPropertiesMapping(EntityTypeBuilder<Character> builder)
        {
            throw new NotImplementedException();
        }
    }

} 

