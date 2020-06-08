using Marvel.Domain.Abstration.Repository.Entities;
using Marvel.Domain.Abstration.Service.Entities;
using Marvel.Domain.Entities;
using Marvel.Domain.Services.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marvel.Domain.Services
{
    public class UrlService : ServiceBase<Url>, IUrlService
    {
        private readonly IUrlRepository _urlRepository;

        public UrlService(IUrlRepository urlRepository)
            : base(urlRepository)
        {
            _urlRepository = urlRepository;
        }
    }
}
