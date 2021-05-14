namespace PCConf.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using PCConf.Data.Extensions;
    using PCConf.Domain.Repositories;
    using PCConf.Models.Parts;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using AppContext = Data.AppContext;

    public class VideoCardRepository : IVideoCardRepository
    {
        private readonly AppContext _appContext;

        public VideoCardRepository(AppContext appContext)
        {
            _appContext = appContext;
        }

        public async void Delete(Guid id)
        {
            _appContext.VideoCards.Remove(_appContext.VideoCards.Find(id));
            await _appContext.SaveChangesAsync();
        }

        public async Task<VideoCard> Get(Guid id)
        {
            return await _appContext.VideoCards.FindAsync(id);
        }

        public async Task<IEnumerable<VideoCard>> Search()
        {
            return await _appContext.VideoCards
                .IncludeAll()
                .ToListAsync();
        }

        public async Task<Guid> Upsert(VideoCard model)
        {
            _appContext.VideoCards.Add(model);
            await _appContext.SaveChangesAsync();

            return model.Id.Value;
        }
    }
}
