using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marvel.Application.Mapping
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(
                config =>
                {
                    config.AddProfile<ApplicationToDomainMappingProfile>();
                }
            );
        }
    }
}
