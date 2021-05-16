namespace PCConf.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using PCConf.Data.Extensions;
    using PCConf.Domain.Repositories;
    using PCConf.Models.Parts;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using AppContext = Data.AppContext;

    public class ProcessorRepository : IProcessorRepository
    {
        private readonly AppContext _appContext;

        public ProcessorRepository(AppContext appContext)
        {
            _appContext = appContext;
        }

        public void Delete(Guid id)
        {
            _appContext.Processors.Remove(_appContext.Processors.Find(id));
            _appContext.SaveChanges();
        }

        public async Task<Processor> Get(Guid id)
        {
            return await _appContext.Processors
                .IncludeAll()
                .FirstOrDefaultAsync(x => x.Id.Equals(id));
        }

        public async Task<IEnumerable<CpuSocket>> GetGpuSockets()
        {
            return await _appContext.CpuSockets.ToListAsync();
        }

        public async Task<IEnumerable<Processor>> Search()
        {
            return await _appContext.Processors
                .IncludeAll()
                .ToListAsync();
        }

        public async Task<Guid> Upsert(Processor model)
        {
            model.Brand = _appContext.Brands.Find(model.Brand.Id);
            model.CpuSocket = _appContext.CpuSockets.Find(model.CpuSocket.Id);
            model.RamType = _appContext.RamTypes.Find(model.RamType.Id);

            _appContext.Processors.Update(model);
            await _appContext.SaveChangesAsync();

            return model.Id.Value;
        }
    }
}
