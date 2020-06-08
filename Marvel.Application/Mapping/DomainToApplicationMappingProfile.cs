using AutoMapper;
using Marvel.Application.Services.Models;
using Marvel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marvel.Application.Mapping
{
    public class DomainToApplicationMappingProfile : Profile
    {
        public DomainToApplicationMappingProfile()
        {
            IMappingExpression<Character, CharacterViewModel> mappingExpression = CreateMap<Character, CharacterViewModel>()
                    .ConstructUsing(c => new CharacterViewModel());

            CreateMap<Url, UrlViewModel>()
                .ConstructUsing(c => new UrlViewModel());

            CreateMap<Comic, ComicViewModel>()
                .ConstructUsing(c => new ComicViewModel());

            CreateMap<ComicSummary, ComicSummaryViewModel>()
                .ConstructUsing(c => new ComicSummaryViewModel());

            CreateMap<Event, EventViewModel>()
                .ConstructUsing(c => new EventViewModel());

            CreateMap<EventSummary, EventSummaryViewModel>()
                .ConstructUsing(c => new EventSummaryViewModel());

            CreateMap<Serie, SerieViewModel>()
                .ConstructUsing(c => new SerieViewModel());

            CreateMap<SerieSummary, SerieSummaryViewModel>()
                .ConstructUsing(c => new SerieSummaryViewModel());

            CreateMap<Image, ImageViewModel>()
                .ConstructUsing(c => new ImageViewModel());

            CreateMap<Story, StoryViewModel>()
                .ConstructUsing(c => new StoryViewModel());

            CreateMap<StorySummary, StorySummaryViewModel>()
                .ConstructUsing(c => new StorySummaryViewModel());

        }
    }
}
