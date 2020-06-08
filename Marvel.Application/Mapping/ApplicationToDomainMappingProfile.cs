using AutoMapper;
using Marvel.Application.Services.Models;
using Marvel.Domain.Entities;

namespace Marvel.Application.Mapping
{
    public class ApplicationToDomainMappingProfile : Profile
    {
        public ApplicationToDomainMappingProfile()
        {
            CreateMap<CharacterInput, Character>()
                .ConstructUsing(c => new Character())
                .ForMember(c => c.Id, c => c.Ignore());

            CreateMap<UrlViewModel, Url>()
                .ConstructUsing(c => new Url())
                .ForMember(c => c.Id, c => c.Ignore())
                .ForMember(c => c.CharacterId, c => c.Ignore())
                .ForMember(c => c.Character, c=> c.Ignore());

            CreateMap<ComicViewModel, Comic>()
                .ConstructUsing(c => new Comic())
                .ForMember(c => c.Id, c => c.Ignore())
                .ForMember(c => c.CharacterId, c => c.Ignore())
                .ForMember(c => c.Character, c => c.Ignore());

            CreateMap<ComicSummaryViewModel, ComicSummary>()
                .ConstructUsing(c => new ComicSummary())
                .ForMember(c => c.Id, c => c.Ignore())
                .ForMember(c => c.ComicId, c => c.Ignore())
                .ForMember(c => c.Comic, c => c.Ignore());


            CreateMap<EventViewModel, Event>()
                .ConstructUsing(c => new Event())
                .ForMember(c => c.Id, c => c.Ignore())
                .ForMember(c => c.CharacterId, c => c.Ignore())
                .ForMember(c => c.Character, c => c.Ignore());

            CreateMap<EventSummaryViewModel, EventSummary>()
                .ConstructUsing(c => new EventSummary())
                .ForMember(c => c.Id, c => c.Ignore())
                .ForMember(c => c.EventId, c => c.Ignore())
                .ForMember(c => c.Event, c => c.Ignore());

            CreateMap<SerieViewModel, Serie>()
                .ConstructUsing(c => new Serie())
                .ForMember(c => c.Id, c => c.Ignore())
                .ForMember(c => c.CharacterId, c => c.Ignore())
                .ForMember(c => c.Character, c => c.Ignore());

            CreateMap<SerieSummaryViewModel, SerieSummary>()
                .ConstructUsing(c => new SerieSummary())
                .ForMember(c => c.Id, c => c.Ignore())
                .ForMember(c => c.SerieId, c => c.Ignore())
                .ForMember(c => c.Serie, c => c.Ignore());

            CreateMap<ImageViewModel, Image>()
                .ConstructUsing(c => new Image())
                .ForMember(c => c.Id, c => c.Ignore())
                .ForMember(c => c.CharacterId, c => c.Ignore())
                .ForMember(c => c.Character, c => c.Ignore());


            CreateMap<StoryViewModel, Story>()
                .ConstructUsing(c => new Story())
                .ForMember(c => c.Id, c => c.Ignore())
                .ForMember(c => c.CharacterId, c => c.Ignore())
                .ForMember(c => c.Character, c => c.Ignore());


            CreateMap<StorySummaryViewModel, StorySummary>()
                .ConstructUsing(c => new StorySummary())
                .ForMember(c => c.Id, c => c.Ignore())
                .ForMember(c => c.StoryId, c => c.Ignore())
                .ForMember(c => c.Story, c => c.Ignore());

        }
    }
}