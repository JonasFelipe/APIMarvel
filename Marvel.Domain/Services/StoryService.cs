using Marvel.Domain.Abstration.Repository.Entities;
using Marvel.Domain.Abstration.Service.Entities;
using Marvel.Domain.Entities;
using Marvel.Domain.Services.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marvel.Domain.Services
{
    public class StoryService : ServiceBase<Story>, IStoryService
    {
        private readonly IStoryRepository _storyRepository;

        public StoryService(IStoryRepository storyRepository)
            : base(storyRepository)
        {
            _storyRepository = storyRepository;
        }
    }
}
