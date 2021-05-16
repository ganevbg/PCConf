namespace PCConf.Domain.Repositories
{
    using PCConf.Models.Parts;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IProcessorRepository : ICrudRepository<Processor>
    {
       Task<IEnumerable<CpuSocket>> GetGpuSockets();
    }
}
