namespace PCConf.Services
{
    using PCConf.Domain.Repositories;
    using PCConf.Domain.Services;
    using PCConf.Models.Parts;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class PowerSuplyService : IPowerSuplyService
    {
        private readonly IPowerSuplyRepository _powerSuplyRepository;

        public PowerSuplyService(IPowerSuplyRepository powerSuplyRepository)
        {
            _powerSuplyRepository = powerSuplyRepository;
        }

        public void Delete(Guid id)
        {
            _powerSuplyRepository.Delete(id);
        }

        public Task<PowerSuply> Get(Guid id)
        {
            return _powerSuplyRepository.Get(id);
        }

        public Task<IEnumerable<PowerSuply>> Search()
        {
            return _powerSuplyRepository.Search();
        }

        public Task<Guid> Upsert(PowerSuply model)
        {
            return _powerSuplyRepository.Upsert(model);
        }
    }
}
