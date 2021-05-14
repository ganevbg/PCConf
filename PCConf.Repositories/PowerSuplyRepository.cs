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

    public class PowerSuplyRepository : IPowerSuplyRepository
    {
        private readonly AppContext _appContext;

        public PowerSuplyRepository(AppContext appContext)
        {
            _appContext = appContext;
        }

        public async void Delete(Guid id)
        {
            _appContext.PowerSuplies.Remove(_appContext.PowerSuplies.Find(id));
            await _appContext.SaveChangesAsync();
        }

        public async Task<PowerSuply> Get(Guid id)
        {
            return await _appContext.PowerSuplies.FindAsync(id);
        }

        public async Task<IEnumerable<PowerSuply>> Search()
        {
            return await _appContext.PowerSuplies
                .IncludeAll()
                .ToListAsync();
        }

        public async Task<Guid> Upsert(PowerSuply model)
        {
            _appContext.PowerSuplies.Add(model);
            await _appContext.SaveChangesAsync();

            return model.Id.Value;
        }
    }
}
