using Marvel.Domain.Abstration.Repository.Entities;
using Marvel.Domain.Entities;
using Marvel.Repository.Context;
using Marvel.Repository.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marvel.Repository.Repositories.Entities
{
    public class SerieRepository : RepositoryBase<Serie>, ISerieRepository
    {
        private readonly MarvelContext marvelContext;

        public SerieRepository(MarvelContext context)
            : base(context)
        {
            marvelContext = context;
        }
    }
}
