namespace PCConf.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using PCConf.Data.Extensions;
    using PCConf.Domain.Repositories;
    using PCConf.Models.Parts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using AppContext = Data.AppContext;

    public class MotherBoardRepository : IMotherBoardRepository
    {
        private readonly AppContext _appContext;

        public MotherBoardRepository(AppContext appContext)
        {
            _appContext = appContext;
        }

        public async void Delete(Guid id)
        {
            _appContext.MotherBoards.Remove(_appContext.MotherBoards.Find(id));
            await _appContext.SaveChangesAsync();
        }

        public async Task<MotherBoard> Get(Guid id)
        {
            return await _appContext.MotherBoards.FindAsync(id);
        }

        public async Task<IEnumerable<MotherBoard>> Search()
        {
            return await _appContext.MotherBoards
                .IncludeAll()
                .ToListAsync();
        }

        public async Task<IEnumerable<MotherBoard>> GetMotherBoardsByCpuSocketAsync(Guid cpuId)
        {
            var cpu = _appContext.Processors
                .Include(c => c.CpuSocket).ToList()
                .Find(x => x.Id.Equals(cpuId));

            if (cpu == null)
            {
                return null;
            }

            return await _appContext.MotherBoards
                .IncludeAll()
                .Where(item => item.CpuSocket.Equals(cpu.CpuSocket))
                .ToListAsync();
        }


        public async Task<Guid> Upsert(MotherBoard model)
        {
            _appContext.MotherBoards.Add(model);
            await _appContext.SaveChangesAsync();

            return model.Id.Value;
        }
    }
}
