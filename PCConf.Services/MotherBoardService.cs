namespace PCConf.Services
{
    using PCConf.Domain.Repositories;
    using PCConf.Domain.Services;
    using PCConf.Models.Parts;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class MotherBoardService : IMotherBoardService
    {
        private readonly IMotherBoardRepository _motherBoardRepository;

        public MotherBoardService(IMotherBoardRepository motherBoardRepository)
        {
            _motherBoardRepository = motherBoardRepository;
        }

        public void Delete(Guid id)
        {
            _motherBoardRepository.Delete(id);
        }

        public Task<MotherBoard> Get(Guid id)
        {
            return _motherBoardRepository.Get(id);
        }

        public Task<IEnumerable<MotherBoard>> Search()
        {
            return _motherBoardRepository.Search();
        }

        public Task<Guid> Upsert(MotherBoard model)
        {
            return _motherBoardRepository.Upsert(model);
        }
    }
}
