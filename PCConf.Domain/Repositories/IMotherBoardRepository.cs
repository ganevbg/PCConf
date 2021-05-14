namespace PCConf.Domain.Repositories
{
    using PCConf.Models.Parts;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IMotherBoardRepository : ICrudRepository<MotherBoard>
    {
        Task<IEnumerable<MotherBoard>> GetMotherBoardsByCpuSocketAsync(string socket);
    }
}
