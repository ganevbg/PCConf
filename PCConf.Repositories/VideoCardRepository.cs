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
            model.Brand = _appContext.Brands.Find(model.Brand.Id);
            model.VideoRamType = _appContext.VideoCardRamTypes.Find(model.VideoRamType.Id);
            model.Interface = _appContext.VideoCardInterfaces.Find(model.Interface.Id);

            _appContext.VideoCards.Update(model);
            await _appContext.SaveChangesAsync();

            return model.Id.Value;
        }
    }
}
