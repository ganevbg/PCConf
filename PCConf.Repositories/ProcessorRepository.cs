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

        public async void Delete(Guid id)
        {
            _appContext.Processors.Remove(_appContext.Processors.Find(id));
            await _appContext.SaveChangesAsync();
        }

        public async Task<Processor> Get(Guid id)
        {
            return await _appContext.Processors.FindAsync(id);
        }

        public async Task<IEnumerable<Processor>> Search()
        {
            return await _appContext.Processors
                .IncludeAll()
                .ToListAsync();
        }

        public async Task<Guid> Upsert(Processor model)
        {
            _appContext.Processors.Add(model);
            await _appContext.SaveChangesAsync();

            return model.Id.Value;
        }
    }
}
