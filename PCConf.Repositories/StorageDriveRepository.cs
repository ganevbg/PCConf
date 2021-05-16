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

    public class StorageDriveRepository : IStorageDriveRepository
    {
        private readonly AppContext _appContext;

        public StorageDriveRepository(AppContext appContext)
        {
            _appContext = appContext;
        }

        public async void Delete(Guid id)
        {
            _appContext.StorageDrives.Remove(_appContext.StorageDrives.Find(id));
            await _appContext.SaveChangesAsync();
        }

        public async Task<StorageDrive> Get(Guid id)
        {
            return await _appContext.StorageDrives.FindAsync(id);
        }

        public async Task<IEnumerable<StorageDrive>> Search()
        {
            return await _appContext.StorageDrives
                .IncludeAll()
                .ToListAsync();
        }

        public async Task<Guid> Upsert(StorageDrive model)
        {
            model.Brand = _appContext.Brands.Find(model.Brand.Id);
            model.Type = _appContext.StorageDriveTypes.Find(model.Type.Id);

            _appContext.StorageDrives.Update(model);
            await _appContext.SaveChangesAsync();

            return model.Id.Value;
        }
    }
}
