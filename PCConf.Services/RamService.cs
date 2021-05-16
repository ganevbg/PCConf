namespace PCConf.Services
{
    using PCConf.Domain.Repositories;
    using PCConf.Domain.Services;
    using PCConf.Models.Parts;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class RamService : IRamService
    {
        private readonly IRamRepository _ramRepository;

        public RamService(IRamRepository ramRepository)
        {
            _ramRepository = ramRepository;
        }

        public void Delete(Guid id)
        {
            _ramRepository.Delete(id);
        }

        public Task<Ram> Get(Guid id)
        {
            return _ramRepository.Get(id);
        }

        public Task<IEnumerable<Ram>> Search()
        {
            return _ramRepository.Search();
        }

        public Task<Guid> Upsert(Ram model)
        {
            return _ramRepository.Upsert(model);
        }
    }
}
