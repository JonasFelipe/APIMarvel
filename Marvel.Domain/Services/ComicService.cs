using Marvel.Domain.Abstration.Repository.Entities;
using Marvel.Domain.Abstration.Service.Entities;
using Marvel.Domain.Entities;
using Marvel.Domain.Services.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marvel.Domain.Services
{
    public class ComicService : ServiceBase<Comic>, IComicService
    {
        private readonly IComicRepository _comicRepository;

        public ComicService(IComicRepository comicRepository)
                : base(comicRepository)
        {
            _comicRepository = comicRepository;
        } 
    }
}

