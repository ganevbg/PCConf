namespace PCConf.Services
{
    using PCConf.Domain.Repositories;
    using PCConf.Domain.Services;
    using PCConf.Models.Parts;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class PartService : IPartService
    {
        private readonly IProcessorRepository _processorRepository;
        private readonly IMotherBoardRepository _motherBoardRepository;
        private readonly IRamRepository _ramRepository;
        private readonly IVideoCardRepository _videoCardRepository;
        private readonly IPcCaseRepository _caseRepository;
        private readonly IPowerSuplyRepository _powerSuplyRepository;
        private readonly IStorageDriveRepository _storageDriveRepository;
        public PartService(
            IProcessorRepository processorRepository,
            IMotherBoardRepository motherBoardRepository,
            IRamRepository ramRepository,
            IVideoCardRepository videoCardRepository,
            IPcCaseRepository caseRepository,
            IPowerSuplyRepository powerSuplyRepository,
            IStorageDriveRepository storageDriveRepository)
        {
            _processorRepository = processorRepository;
            _motherBoardRepository = motherBoardRepository;
            _ramRepository = ramRepository;
            _videoCardRepository = videoCardRepository;
            _caseRepository = caseRepository;
            _powerSuplyRepository = powerSuplyRepository;
            _storageDriveRepository = storageDriveRepository;
        }

        public async Task<IEnumerable<Processor>> GetAllProcessorsAsync()
        {
            return await _processorRepository.Search();
        }

        public async Task<IEnumerable<MotherBoard>> GetMotherBoardsByCpuSocketAsync(Guid cpuId)
        {
            return await _motherBoardRepository.GetMotherBoardsByCpuSocketAsync(cpuId);
        }

        public async Task<IEnumerable<Ram>> GetRamsByTypeAsync(Guid mbId)
        {
            return await _ramRepository.GetRamsByType(mbId);
        }

        public async Task<IEnumerable<VideoCard>> GetVideoCardsAsync()
        {
            return await _videoCardRepository.Search();
        }

        public async Task<IEnumerable<PcCase>> GetCaseByMotherBoardAndVideCardAsync(Guid motherBoardId, Guid videCardId)
        {
            return await _caseRepository.GetCaseByMotherBoardAndVideCard(motherBoardId, videCardId);
        }


        public async Task<IEnumerable<PcCase>> GetAllMotherBoards()
        {
            return await _caseRepository.Search();
        }

        public async Task<IEnumerable<PowerSuply>> GetPowerSupliesAsync()
        {
            return await _powerSuplyRepository.Search();
        }

        public async Task<IEnumerable<StorageDrive>> GetDrivesAsync()
        {
            return await _storageDriveRepository.Search();
        }
    }
}