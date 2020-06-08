using Marvel.Domain.Abstration.Repository.Entities;
using Marvel.Domain.Abstration.Service.Entities;
using Marvel.Domain.Entities;
using Marvel.Domain.Services.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marvel.Domain.Services
{
    public class SerieService : ServiceBase<Serie>, ISerieService
    {
        private readonly ISerieRepository _serieRepository;

        public SerieService(ISerieRepository serieRepository)
            : base(serieRepository)
        {
            _serieRepository = serieRepository;
        }
    }
}
