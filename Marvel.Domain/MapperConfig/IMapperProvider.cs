using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marvel.Domain.MapperConfig
{
    public interface IMapperProvider
    {
        IMapper GetMapper();
    }
}
