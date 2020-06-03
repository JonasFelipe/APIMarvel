using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marvel.Domain.MapperConfig
{
    public static class AutoMapperExtension
    {
        public static TDestination MapTo<TDestination>(this object source)
        {

            return <TDestination>(source);
        }

    }
}
