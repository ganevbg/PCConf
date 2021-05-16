namespace PCConf.Services
{
    using PCConf.Domain.Repositories;
    using PCConf.Domain.Services;
    using PCConf.Models.Parts;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class StorageDriveService : IStorageDriveService
    {
        private readonly IStorageDriveRepository _stogareDriveRepository;

        public StorageDriveService(IStorageDriveRepository stogareDriveRepository)
        {
            _stogareDriveRepository = stogareDriveRepository;
        }

        public void Delete(Guid id)
        {
            _stogareDriveRepository.Delete(id);
        }

        public Task<StorageDrive> Get(Guid id)
        {
            return _stogareDriveRepository.Get(id);
        }

        public Task<IEnumerable<StorageDrive>> Search()
        {
            return _stogareDriveRepository.Search();
        }

        public Task<Guid> Upsert(StorageDrive model)
        {
            return _stogareDriveRepository.Upsert(model);
        }
    }
}
