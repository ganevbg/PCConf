namespace PCConf.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using PCConf.Domain.Repositories;
    using PCConf.Models.Parts;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using AppContext = Data.AppContext;

    public class BrandRepository : IBrandRepository
    {
        private readonly AppContext _appContext;

        public BrandRepository(AppContext appContext)
        {
            _appContext = appContext;
        }

        public async void Delete(Guid id)
        {
            _appContext.MotherBoards.Remove(_appContext.MotherBoards.Find(id));
            await _appContext.SaveChangesAsync();
        }

        public async Task<Brand> Get(Guid id)
        {
            return await _appContext.Brands.FindAsync(id);
        }

        public async Task<IEnumerable<Brand>> Search()
        {
            return await _appContext.Brands.ToListAsync();
        }

      

        public async Task<Guid> Upsert(Brand model)
        {
            _appContext.Brands.Update(model);
            await _appContext.SaveChangesAsync();

            return model.Id.Value;
        }
    }
}
