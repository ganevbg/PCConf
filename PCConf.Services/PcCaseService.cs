namespace PCConf.Services
{
    using PCConf.Domain.Repositories;
    using PCConf.Domain.Services;
    using PCConf.Models.Parts;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class PcCaseService : IPcCaseService
    {
        private readonly IPcCaseRepository _pcCaseRepository;

        public PcCaseService(IPcCaseRepository pcCaseRepository)
        {
            _pcCaseRepository = pcCaseRepository;
        }

        public void Delete(Guid id)
        {
            _pcCaseRepository.Delete(id);
        }

        public Task<PcCase> Get(Guid id)
        {
            return _pcCaseRepository.Get(id);
        }

        public Task<IEnumerable<PcCase>> Search()
        {
            return _pcCaseRepository.Search();
        }

        public Task<Guid> Upsert(PcCase model)
        {
            return _pcCaseRepository.Upsert(model);
        }
    }
}
