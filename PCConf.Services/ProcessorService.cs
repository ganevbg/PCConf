namespace PCConf.Services
{
    using PCConf.Domain.Repositories;
    using PCConf.Domain.Services;
    using PCConf.Models.Parts;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class ProcessorService : IProcessorService
    {
        private readonly IProcessorRepository _processorRepository;

        public ProcessorService(IProcessorRepository processorRepository)
        {
            _processorRepository = processorRepository;
        }

        public void Delete(Guid id)
        {
            _processorRepository.Delete(id);
        }

        public Task<Processor> Get(Guid id)
        {
            return _processorRepository.Get(id);
        }

        public Task<IEnumerable<Processor>> Search()
        {
            return _processorRepository.Search();
        }

        public Task<Guid> Upsert(Processor model)
        {
            return _processorRepository.Upsert(model);
        }
    }
}
