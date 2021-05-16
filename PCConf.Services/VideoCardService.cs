namespace PCConf.Services
{
    using PCConf.Domain.Repositories;
    using PCConf.Domain.Services;
    using PCConf.Models.Parts;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class VideoCardService : IVideoCardService
    {
        private readonly IVideoCardRepository _videoCardRepository;

        public VideoCardService(IVideoCardRepository videoCardRepository)
        {
            _videoCardRepository = videoCardRepository;
        }

        public void Delete(Guid id)
        {
            _videoCardRepository.Delete(id);
        }

        public Task<VideoCard> Get(Guid id)
        {
            return _videoCardRepository.Get(id);
        }

        public Task<IEnumerable<VideoCard>> Search()
        {
            return _videoCardRepository.Search();
        }

        public Task<Guid> Upsert(VideoCard model)
        {
            return _videoCardRepository.Upsert(model);
        }
    }
}
