using Marvel.Domain.Abstration.Repository.Entities;
using Marvel.Domain.Entities;
using Marvel.Repository.Context;
using Marvel.Repository.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marvel.Repository.Repositories.Entities
{
    public class UrlRepository : RepositoryBase<Url>, IUrlRepository
    {
        private readonly MarvelContext marvelContext;

        public UrlRepository(MarvelContext context)
            : base(context)
        {
            marvelContext = context;
        }
    }
}
