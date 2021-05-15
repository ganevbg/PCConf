namespace PCConf.Domain.Services
{
    using PCConf.Models.Parts;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IPartService
    {
        Task<IEnumerable<Processor>> GetAllProcessorsAsync();

        Task<IEnumerable<MotherBoard>> GetMotherBoardsByCpuSocketAsync(Guid cpuId);

        Task<IEnumerable<Ram>> GetRamsByTypeAsync(Guid mbId);

        Task<IEnumerable<VideoCard>> GetVideoCardsAsync();

        Task<IEnumerable<PcCase>> GetCaseByMotherBoardAndVideCardAsync(Guid motherBoardId, Guid videCardId);

        Task<IEnumerable<PowerSuply>> GetPowerSupliesAsync();

        Task<IEnumerable<StorageDrive>> GetDrivesAsync();

        Task<IEnumerable<PcCase>> GetAllMotherBoards();
    }
}
