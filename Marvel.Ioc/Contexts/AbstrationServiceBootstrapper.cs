using Marvel.Application.Abstration;
using Marvel.Application.Services.AppCharacter;
using Marvel.Domain.Abstration.Repository.Entities;
using Marvel.Domain.Abstration.Service.Entities;
using Marvel.Domain.Services;
using Marvel.Repository.Repositories.Entities;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marvel.Ioc.Contexts
{
    internal class AbstrationServiceBootstrapper
    {
        internal void ChildServiceRegister(IServiceCollection services)
        {
            RegisterAppServices(services);
            RegisterData(services);
            RegisterDomainServices(services);
        }

        private void RegisterDomainServices(IServiceCollection services)
        {
            services.AddScoped<ICharacterService, CharacterService>();
            services.AddScoped<IComicService, ComicService>();
            services.AddScoped<IImageService, ImageService>();
            services.AddScoped<IEventService, EventService>();
            services.AddScoped<ISerieService, SerieService>();
            services.AddScoped<IStoryService, StoryService>();
        }

        private void RegisterData(IServiceCollection services)
        {
            services.AddScoped<ICharacterRepository, CharacterRepository>();
            services.AddScoped<IComicRepository, ComicRepository>();
            services.AddScoped<IImageRepository, ImageRepository>();
            services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<ISerieRepository, SerieRepository>();
            services.AddScoped<IStoryRepository, StoryRepository>();
        }

        private void RegisterAppServices(IServiceCollection services)
        {
            services.AddScoped<ICharacterAppService, CharacterAppService>();
            //services.AddScoped<ICompraGadoItemAppService, CompraGadoItemAppService>();
        }
    }
}
