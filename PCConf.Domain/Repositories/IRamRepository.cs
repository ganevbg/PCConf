namespace PCConf.Domain.Repositories
{
    using PCConf.Models.Parts;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IRamRepository : ICrudRepository<Ram>
    {
        Task<IEnumerable<Ram>> GetRamsByType(Guid mbId);

        Task<IEnumerable<RamType>> GetRamTypes();
    }
}
