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

    public class RamRepository : IRamRepository
    {
        private readonly AppContext _appContext;

        public RamRepository(AppContext appContext)
        {
            _appContext = appContext;
        }

        public async void Delete(Guid id)
        {
            _appContext.Rams.Remove(_appContext.Rams.Find(id));
            await _appContext.SaveChangesAsync();
        }

        public async Task<Ram> Get(Guid id)
        {
            return await _appContext.Rams.FindAsync(id);
        }

        public async Task<IEnumerable<Ram>> GetRamsByType(Guid mbId)
        {
            var mb = _appContext.MotherBoards
                .Include(c => c.RamType).ToList()
                .Find(x => x.Id.Equals(mbId));

            if (mb == null)
            {
                return null;
            }

            return await _appContext.Rams
                .IncludeAll()
                .Where(item => item.Type.Equals(mb.RamType))
                .ToListAsync();
        }

        public async Task<IEnumerable<Ram>> Search()
        {
            return await _appContext.Rams
                .IncludeAll()
                .ToListAsync();
        }

        public async Task<Guid> Upsert(Ram model)
        {
            _appContext.Rams.Add(model);
            await _appContext.SaveChangesAsync();

            return model.Id.Value;
        }
    }
}
