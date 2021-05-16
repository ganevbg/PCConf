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

    public class PcCaseRepository : IPcCaseRepository
    {
        private readonly AppContext _appContext;

        public PcCaseRepository(AppContext appContext)
        {
            _appContext = appContext;
        }

        public async void Delete(Guid id)
        {
            _appContext.PcCases.Remove(_appContext.PcCases.Find(id));
            await _appContext.SaveChangesAsync();
        }

        public async Task<PcCase> Get(Guid id)
        {
            return await _appContext.PcCases.FindAsync(id);
        }

        public async Task<IEnumerable<PcCase>> GetCaseByMotherBoardAndVideCard(Guid motherBoardId, Guid videCardId)
        {
            using (_appContext)
            {
                var mb = _appContext.MotherBoards.IncludeAll().FirstOrDefault(x => x.Id.Equals(motherBoardId));
                var gpu = _appContext.VideoCards.IncludeAll().FirstOrDefault(x => x.Id.Equals(videCardId));

                if (mb == null || gpu == null)
                {
                    return null;
                }

                return await _appContext.PcCases
                    .IncludeAll()
                    .Where(item => _appContext.PcCaseFormat.Any(a => a.FormatId.Equals(mb.Format.Id) && a.PcCaseId.Equals(item.Id))
                    && item.MaxVideoCardSize >= gpu.Length)
                    .ToListAsync();
            }
        }

        public async Task<IEnumerable<PcCase>> Search()
        {
            return await _appContext.PcCases
                .IncludeAll()
                .ToListAsync();
        }

        public async Task<Guid> Upsert(PcCase model)
        {
            model.Brand = _appContext.Brands.Find(model.Brand.Id);
            model.Formats = _appContext.PcCaseFormat.Where(x => model.Formats.Contains(x));

            _appContext.PcCases.Update(model);
            await _appContext.SaveChangesAsync();

            return model.Id.Value;
        }
    }
}
