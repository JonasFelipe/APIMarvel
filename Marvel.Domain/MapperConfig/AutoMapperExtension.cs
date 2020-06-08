using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marvel.Domain.MapperConfig
{
    public static class AutoMapperExtension
    {
        public class Source<T>
        {
            public T Value { get; set; }
        }

        public class Destination<T>
        {
            public T Value { get; set; }
        }

        public static TDestination MapTo<TDestination>(object source)
        {
            Source<object> source1 = new Source<object>();
            source1.Value = source;

            Destination<TDestination> destination = new Destination<TDestination>();

            var configuration = new MapperConfiguration(cfg => cfg.CreateMap(typeof(Source<>), typeof(Destination<>)));

            var map = configuration.CreateMapper().Map<TDestination>(source1.Value);

            return map;
        }

    }
}
