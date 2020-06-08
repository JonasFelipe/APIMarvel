using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marvel.Domain.MapperConfig
{
    public static class AutoMapperExtension
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(
                config =>
                {
                    //config.AddProfile<ApplicationToDomainMappingProfile>();
                    config.AddProfile<EntityDomainToApplicationMappingProfile>();
                }
            );
        }
    }
}
