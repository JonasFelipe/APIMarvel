using Marvel.Domain.Abstration.Repository.Entities;
using Marvel.Domain.Abstration.Service.Entities;
using Marvel.Domain.Entities;
using Marvel.Domain.Services.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marvel.Domain.Services
{
    public class EventService : ServiceBase<Event>, IEventService
    {
        private readonly IEventRepository _eventRepository;

        public EventService(IEventRepository eventRepository)
            : base(eventRepository)
        {
            _eventRepository = eventRepository;
        }
    }
}
