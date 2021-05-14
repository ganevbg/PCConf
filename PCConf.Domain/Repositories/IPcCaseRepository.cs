namespace PCConf.Domain.Repositories
{
    using PCConf.Models.Parts;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IPcCaseRepository : ICrudRepository<PcCase>
    {
        Task<IEnumerable<PcCase>> GetCaseByMotherBoardAndVideCard(Guid motherBoardId, Guid videCardId);
    }
}
