using Marvel.Domain.Abstration.Repository.Entities;
using Marvel.Domain.Abstration.Service.Entities;
using Marvel.Domain.Entities;
using Marvel.Domain.Services.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marvel.Domain.Services
{
    public class ImageService : ServiceBase<Image>, IImageService
    {
        private readonly IImageRepository _imageRepository;

        public ImageService(IImageRepository imageRepository)
                : base(imageRepository)
        {
            _imageRepository = imageRepository;
        }
    }
}
