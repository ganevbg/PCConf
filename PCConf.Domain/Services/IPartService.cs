namespace PCConf.Domain.Services
{
    using PCConf.Models.Parts;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IPartService
    {
        Task<IEnumerable<Processor>> GetAllProcessorsAsync();

        Task<IEnumerable<MotherBoard>> GetMotherBoardsByCpuSocketAsync(string socket);

        Task<IEnumerable<Ram>> GetRamsByTypeAsync(string type);

        Task<IEnumerable<VideoCard>> GetVideoCardsAsync();

        Task<IEnumerable<PcCase>> GetCaseByMotherBoardAndVideCardAsync(Guid motherBoardId, Guid videCardId);

        Task<IEnumerable<PowerSuply>> GetPowerSupliesAsync();

        Task<IEnumerable<StorageDrive>> GetDrivesAsync();
    }
}
