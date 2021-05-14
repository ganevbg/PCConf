namespace PCConf.Domain.Repositories
{
    using PCConf.Models.Parts;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IRamRepository : ICrudRepository<Ram>
    {
        Task<IEnumerable<Ram>> GetRamsByType(string type);
    }
}
